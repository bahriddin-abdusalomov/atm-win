using ATM.Project.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Project.Forms
{
    public partial class UzPage : Form
    {
        public UzPage()
        {
            InitializeComponent();
        }

        private void textBoxParol_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonParol_Click(object sender, EventArgs e)
        {
            Card card = new Card();

            card.Password = textBoxParol.Text;

            if (card.Password != null )
            {
                            
            }
            else
            {
                labelParol.Text = "Noto'g'ri parol kiritdingiz !";
                labelParol.ForeColor = Color.Red;
            }
        }
    }
}
