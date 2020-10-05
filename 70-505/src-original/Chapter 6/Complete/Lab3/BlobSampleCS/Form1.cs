using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BlobSampleCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   
        
        private SqlConnection NorthwindConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");
        private String CompleteFilePath = "";
        private String SavePath = "";

        private void GetCompleteFilePath()
        {
            OpenFileDialog OpenDialog = new OpenFileDialog();
            OpenDialog.Title = "Select Document to Save";
            OpenDialog.ShowDialog();
            CompleteFilePath = OpenDialog.FileName;
        }

        private void GetSavePath()
        {
            FolderBrowserDialog SavePathDialog = new FolderBrowserDialog();
            SavePathDialog.Description = "Select a folder to restore BLOB file to";
            SavePathDialog.ShowDialog();
            SavePath = SavePathDialog.SelectedPath;
        }

        // Create a table to hold our BLOB values.
        private void CreateDocumentStorageTable()
        {
            SqlCommand CreateTableCommand = new SqlCommand();
            CreateTableCommand.Connection = NorthwindConnection;
            CreateTableCommand.CommandType = CommandType.Text;
            CreateTableCommand.CommandText = 
                        "IF OBJECT_ID ( 'DocumentStorage' ) IS NOT NULL " +
                        "DROP TABLE DocumentStorage; " +
                        "CREATE TABLE DocumentStorage(" +
                        "DocumentID int IDENTITY(1,1) NOT NULL, " +
                        "FileName nvarchar(255) NOT NULL, " +
                        "DocumentFile varbinary(max) NOT NULL)";

            CreateTableCommand.Connection.Open();
            CreateTableCommand.ExecuteNonQuery();
            CreateTableCommand.Connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Create the Document Storage Table?" + Environment.NewLine + "Click Yes to create a new DocumentStorage table. Click No if you already have one!", "Create DocumentStorage table", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            switch (response)
            {
                case DialogResult.Yes:
                    CreateDocumentStorageTable();
                    break;
                case DialogResult.No:
                    RefreshBlobList();
                    break;
            }

        }

        private void RefreshBlobList()
        {
            SqlCommand GetBlobListCommand = new SqlCommand("SELECT FileName FROM DocumentStorage", NorthwindConnection);
            SqlDataReader reader;

            GetBlobListCommand.Connection.Open();
            reader = GetBlobListCommand.ExecuteReader();
            while (reader.Read())
            {
                BlobList.Items.Add(reader[0]);
            }
            reader.Close();
            GetBlobListCommand.Connection.Close();
            try
            {
                BlobList.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No BLOBs to list, save one to the database!");
            }
        }

private void SaveBlobToDatabase()
{
    // This call lets you select the
    // binary file to save as a BLOB
    // in the database.
    GetCompleteFilePath();

    // The BLOB holds the byte array to save.
    byte[] BLOB;

    // The FileStream is the stream of bytes
    // that represent the binary file.
    System.IO.FileStream FileStream = new System.IO.FileStream(CompleteFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);

    // The reader reads the binary data from the FileStream.
    System.IO.BinaryReader reader = new System.IO.BinaryReader(FileStream);

    // The BLOB is asigned the bytes from the reader.
    // The file length is passed to the ReadBytes method
    // telling it how many bytes to read.

    System.IO.FileInfo file = new FileInfo(CompleteFilePath);

    BLOB = reader.ReadBytes((int)(file.Length));

    FileStream.Close();
    reader.Close();

    // Create a command object to save
    // the BLOB value.
    SqlCommand SaveDocCommand = new SqlCommand();
    SaveDocCommand.Connection = NorthwindConnection;
    SaveDocCommand.CommandText = "INSERT INTO DocumentStorage" +
                     "(FileName, DocumentFile)" +
                     "VALUES (@FileName, @DocumentFile)";

    // Create parameters to store the filename and BLOB data.
    SqlParameter FileNameParameter = new SqlParameter("@FileName", SqlDbType.NChar);
    SqlParameter DocumentFileParameter = new SqlParameter("@DocumentFile", SqlDbType.Binary);
    SaveDocCommand.Parameters.Add(FileNameParameter);
    SaveDocCommand.Parameters.Add(DocumentFileParameter);
        
    // Parse the filename out of the complete path
    // and assign it to the parameter.
    FileNameParameter.Value = CompleteFilePath.Substring(CompleteFilePath.LastIndexOf("\\")+ 1);

    // Set the DocumentFile parameteter to the BLOB Value.
    DocumentFileParameter.Value = BLOB;

    // Execute the command and save the BLOB to the database.
    try
    {
        SaveDocCommand.Connection.Open();
        SaveDocCommand.ExecuteNonQuery();
        MessageBox.Show(FileNameParameter.Value.ToString() + " saved to database.", "BLOB Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
        SaveDocCommand.Connection.Close();
    }
}






        private void FetchBlobFromDatabase()
        { 
        // Verify there is a BLOB selected to retrieve.
        if (BlobList.Text == "")
        {
        MessageBox.Show("Select a BLOB to fetch from the ComboBox");
        return;
        }


        // Get the path to save the BLOB to.
        GetSavePath();

        // Create the Command object to fetch the selected BLOB.
        SqlCommand GetBlobCommand = new SqlCommand("SELECT FileName, DocumentFile " +
                                            "FROM DocumentStorage " +
                                            "WHERE FileName = @DocName", NorthwindConnection);

        GetBlobCommand.Parameters.Add("@DocName", SqlDbType.NVarChar).Value = BlobList.Text;


        // Current index to write the bytes to
        long CurrentIndex = 0;

        // number of bytes to store in the BLOB.
        int BufferSize = 100;

        // Actual number of bytes returned when calling GetBytes.
        long BytesReturned ;

        // The Byte array used to hold the buffer.
        byte[] Blob = new byte[BufferSize];

        GetBlobCommand.Connection.Open();

        SqlDataReader reader = GetBlobCommand.ExecuteReader(CommandBehavior.SequentialAccess);

        while(reader.Read())
        {
        // Create or open the selected file.
        System.IO.FileStream FileStream = new System.IO.FileStream(SavePath + "\\" + reader["FileName"].ToString(), System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);

        // Set the writer to write the BLOB to the file.
        System.IO.BinaryWriter writer= new System.IO.BinaryWriter(FileStream);

        // Reset the index to the beginning of the file.
        CurrentIndex = 0;

        // Set the BytesReturned to the actual number
        // of bytes returned by the GetBytes call.
        BytesReturned = reader.GetBytes(1, CurrentIndex, Blob, 0, BufferSize);

        // If the BytesReturned fills the buffer
        // keep appending to the file.
        while (BytesReturned == BufferSize)
        {
            writer.Write(Blob);
            writer.Flush();

            CurrentIndex += BufferSize;
            BytesReturned = reader.GetBytes(1, CurrentIndex, Blob, 0, BufferSize);
        }


        // When the BytesReturned no longer fills
        // the buffer, write the remaining bytes.
        writer.Write(Blob, 0, (int)(BytesReturned));
        writer.Flush();

        writer.Close();
        FileStream.Close();
        }
        reader.Close();
        GetBlobCommand.Connection.Close();
        }

        private void RefreshBlobListButton_Click(object sender, EventArgs e)
        {
            RefreshBlobList();
        }

        private void SaveBlobButton_Click(object sender, EventArgs e)
        {
            SaveBlobToDatabase();
        }

        private void FetchBlobButton_Click(object sender, EventArgs e)
        {
            FetchBlobFromDatabase();
        }

    }
}
