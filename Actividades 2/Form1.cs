using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividades_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ltvData.View = View.Details;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == null || txtName.Text==null || txtPrice.Text==null|| dudCategory.Text== null||nupQuantity.Value==0)
            {
                MessageBox.Show("Fill in all the fields");
                txtDescription.Clear();
                txtName.Clear();
                txtPrice.Clear();
                dudCategory.Refresh();
                nupQuantity.Update();
                return;
            }
            Product products = new Product(txtName.Text, decimal.Parse(txtPrice.Text), Convert.ToInt32(nupQuantity.Value), dudCategory.Text,txtDescription.Text );
            string[] row= products.ToString().Split(',');
            ltvData.Items.Add(new ListViewItem(row));
            txtDescription.Clear();
            txtName.Clear();
            txtPrice.Clear();
            dudCategory.Refresh();
            nupQuantity.Update();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (char.IsControl(character) || !(char.IsDigit(character) || (!(character != '.'))))
            {
                e.Handled = true;
            }
            if (character == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (!char.IsLetter(character))
            {
                e.Handled = true;
            }
            
        }
    }
}
