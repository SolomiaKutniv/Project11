using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project11
{
    public partial class Form1 : Form
    {
        private Wolf[] wolves = new Wolf[100];
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddWolf_Click(object sender, EventArgs e)
        {
            if (count >= wolves.Length)
            {
                MessageBox.Show("Масив вовків заповнений!");
                return;
            }

            double weight = Convert.ToDouble(txtWeight.Text);
            int age = Convert.ToInt32(txtAge.Text);
            double cost = Convert.ToDouble(txtCost.Text); 
            string breed = txtBreed.Text;
            string location = txtLocation.Text;

            Wolf newWolf = new Wolf(weight, age, cost, breed, location);
            wolves[count] = newWolf;
            count++;

            
            lstWolves.Items.Add("Вовк №" + count + ":" + newWolf.Info());


            txtWeight.Clear();
            txtAge.Clear();
            txtCost.Clear();
            txtBreed.Clear();
            txtLocation.Clear();
        }
    }
}
