using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinqToXml
{
    public partial class LinqToXmlForm : Form
    {
        public LinqToXmlForm()
        {
            InitializeComponent();
        }

private void LoadProductsButton_Click(object sender, EventArgs e)
{
    XElement root = XElement.Load("NorthwindProducts.xml");


    IEnumerable<XElement> product =
        from el in root.Descendants("Products")
        orderby el.Element("ProductName").Value
        select el;

    foreach (XElement el in product)
    {
        resultsListBox.Items.Add(el.Element("ProductName").Value);
    }

    resultsListBox.SelectedIndex = 0;
 }

private void GetProductInfoButton_Click(object sender, EventArgs e)
{
            XElement root = XElement.Load("NorthwindProducts.xml");


            IEnumerable<XElement> product =
                from el in root.Descendants("Products")
                where (el.Element("ProductName").Value == resultsListBox.SelectedItem.ToString())
                select el;

            foreach (XElement el in product)
            {
                quantityPerUnitTextBox.Text = el.Element("QuantityPerUnit").Value;
                unitPriceTextBox.Text = el.Element("UnitPrice").Value;
                unitsInStockTextBox.Text = el.Element("UnitsInStock").Value;
            }
}
    }
}
