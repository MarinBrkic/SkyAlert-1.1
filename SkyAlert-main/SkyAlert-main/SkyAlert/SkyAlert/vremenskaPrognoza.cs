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
    public partial class vremenskaPrognoza : Form
    {
        private string grad;
        public vremenskaPrognoza(string imeGrada)
        {
            InitializeComponent();
            grad = imeGrada;
            labelImeGrada.Text = $"Vremenska prognoza u: {grad}";
            UcitajVremenskuPrognozu();
        }

        private async void UcitajVremenskuPrognozu() {}

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Close();
        }
    }
}
