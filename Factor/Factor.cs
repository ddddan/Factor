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
            fd.Value = newValue;
            List<int> factors = fd.Factors();

            String message = "# of factors: " + Convert.ToString(factors.Count);

            MessageBox.Show(message, "Factors");


            this.ResultsPanel.Invalidate();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            origValue = Convert.ToInt32(this.inputBox.Text);
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
