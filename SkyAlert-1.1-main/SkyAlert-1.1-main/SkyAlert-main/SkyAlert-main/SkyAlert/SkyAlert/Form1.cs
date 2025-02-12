using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyAlert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string grad = textBoxImeGrada.Text.Trim();
            if (!string.IsNullOrEmpty(grad))
            {
                vremenskaPrognoza vremenskaPrognoza = new vremenskaPrognoza(grad);

                vremenskaPrognoza.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Molimo unesite ime grada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
