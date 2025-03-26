using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateAreaButton_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = Convert.ToDouble(radiusTextBox.Text);
                double circleArea = Math.PI * Math.Pow(radius, 2);
                MessageBox.Show($"Площа кола = {circleArea}", "Результат", MessageBoxButtons.OK);
            } catch (FormatException)
            {
                MessageBox.Show("Саталася помилка, перевірте правельність введених даних.", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
