using MySql.Data.MySqlClient;
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
    public partial class SarkiEkle : Form
    {
        string baglanti = "Server=localhost;Database=muzik;Uid=root;Pwd=;";
        public SarkiEkle()
        {
            InitializeComponent();
        }

        private void btnSarkiEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
               string sorgu = "INSERT INTO sarkilar VALUES(NULL,@sarkiAd,@sanatciAd,@yil,@tur,@sure,@tarih,@favori);";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@sarkiAd", txtSarkiAdi.Text);
                cmd.Parameters.AddWithValue("@sanatciAd", txtSanatci.Text);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.Text);
                cmd.Parameters.AddWithValue("@sure", txtSure.Text);
                cmd.Parameters.AddWithValue("@tarih", dtpTarih.Text);
                cmd.Parameters.AddWithValue("@favori",cbFavori.Checked);
                  
                //sorguyu çalıştırma komutu kayıt eklenirse satır sayısı döner
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kayıt Eklendi!");
                    this.Close();
                }
              
                    }
            //cmb doldurma metodu
            void CmbTurDoldur()
            {
                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();
                    string sorgu = " SELECT DISTINCT tur FROM sarkilar;";

                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    cmbTur.DataSource = dt;
                    cmbTur.DisplayMember = "tur";
                    cmbTur.ValueMember = "tur";
                }

            }
        }
    }
}
