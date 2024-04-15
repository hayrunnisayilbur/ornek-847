using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSarkiEkle_Click(object sender, EventArgs e)
        {
           FormSarkiEkle sarkiEkle = new FormSarkiEkle();
           sarkiEkle.ShowDialog();
        }

        private void btnTumSarkilar_Click(object sender, EventArgs e)
        {
            FormTumSarkilar sarkilar = new FormTumSarkilar();
            sarkilar.ShowDialog();

        }
    }
}
