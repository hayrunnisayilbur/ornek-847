using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class FormTumSarkilar : Form
    {
        string baglanti = "Server=localhost;Database=muzik;Uid=root;Pwd=;";
        public FormTumSarkilar()
        {
            InitializeComponent();
        }

        private void FormTumSarkilar_Load(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM sarkilar;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();


                da.Fill(dt);
                dgwSarkilar.DataSource = dt;
            }
        }
    }
}
