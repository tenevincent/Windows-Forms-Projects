using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinqToObjects
{
    public partial class LinqToObjectsForm : Form
    {
        public LinqToObjectsForm()
        {
            InitializeComponent();
        }

        private void query1Button_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();

            IEnumerable<Control> Query =
                from Control buttons in this.Controls
                where (buttons is Button)
                orderby buttons.Text
                select buttons;

            int buttonCount = Query.Count();
            infoLabel.Text = "The following " + Query.Count().ToString() + " buttons are on this form:";
            foreach (Button b in Query)
            {
                resultsListBox.Items.Add(b.Name);
            }

        }

        private void query2Button_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();

            var query = from Player p in players
                        where p.Scores.Average() > 160
                        select p;
            infoLabel.Text = "The following players have score averages over 160:";
            foreach (Player p1 in query)
                resultsListBox.Items.Add(p1.Name + ": avg=" + p1.Scores.Average());
        }

        public class Player
        {
            public string Name { get; set; }
            public List<int> Scores { get; set; }
        }

        public List<Player> players = new List<Player>
        {
            new Player {Name="Alfreds Futterkiste", 
                Scores = new List<int>{156,187,207}},
            new Player {Name="Eastern Connection", 
                Scores = new List<int>{127,156,198}},
            new Player {Name="Hanari Carnes", 
                Scores = new List<int>{144,148,203}},
            new Player {Name="Island Trading", 
                Scores = new List<int>{158,167,144}},
            new Player {Name="Simons bistro", 
                Scores = new List<int>{188,173,189}}

        };

        private void query3Button_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();

            var query = from Player p in players
                        group new { p.Name } 
                            by p.Scores.Max() > 200 into Over200Group
                        select Over200Group;


            infoLabel.Text = "Players with high scores over 200:";

            foreach (var over200Group in query)
            {
                resultsListBox.Items.Add(over200Group.Key.ToString());
                foreach (var p in over200Group)
                    resultsListBox.Items.Add("\t" + p.Name);
            }
        }
    
    
    
    
    }
}
