using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factor
{

    public partial class Factor : Form
    {
        private FactorData fd;
        private int origValue;

        public Factor()
        {
            InitializeComponent();
            fd = new FactorData();
        }

        public void DoFactoring(int newValue)
        {
            // Clear ResultsPanel
            ResultsPanel.Controls.Clear();
            
            // Initialize the FactorData object
            fd.Value = newValue;

            // Calculate the list of factors
            List<int> factors = fd.Factors();

            // Display the numbers as a series of labels inside ResultsPanel
            foreach (int f in factors)
            {
                Label l = new Label();
                l.AutoSize = true;
                l.Text = f.ToString();
                ResultsPanel.Controls.Add(l);
            }


            this.ResultsPanel.Invalidate();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            // Read in input and convert to string
            string inputString = this.inputBox.Text;
            int input;
            if (Int32.TryParse(inputString, out input))
            {
                origValue = input;
            }
        }


        private void lvOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnGo_Click(object sender, EventArgs e)
        {
            if (origValue > 1)
            {
                DoFactoring(origValue);
            }
        }

        private void ResultsPanel_Paint(object sender, PaintEventArgs e)
        {
            this.ResultsPanel.Text = "Hello, World!";
        }
    }
}
