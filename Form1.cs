using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigm22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String Cost_S = textBox1.Text;
                double Cost = Convert.ToDouble(Cost_S);
                String tips = Convert.ToString(Cost * 0.15);
                String taxs = Convert.ToString(Cost * 0.10);
                String totals = Convert.ToString(Cost * 0.10 + Cost * 0.15 + Cost);
                label5.Text = tips + " BD";
                label6.Text = taxs + " BD";
                label7.Text = totals + " BD";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = fontDialog.Font;
                    textBox1.ForeColor = fontDialog.Color;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mealCharge = textBox1.Text;
            string totals = label7.Text;

            MessageBox.Show($"Meal charge : {mealCharge}\n  total amount: {totals}", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
