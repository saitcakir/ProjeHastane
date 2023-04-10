using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProjeHastane
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //Doktorları Listeye Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Doctor", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branşı comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BranchName from Tbl_Branch", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //Şehir Çekme

            SqlCommand komut4 = new SqlCommand("Select CityName from Tbl_City", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                CmbCity.Items.Add(dr4[0]);
            }
            bgl.baglanti().Close();





        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doctor (DoctorName,DoctorSurname,DoctorBranch,DoctorTC,DoctorPassword,CityName,HospitalName) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", MskTC.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.Parameters.AddWithValue("@d6", CmbCity.Text);
            komut.Parameters.AddWithValue("@d7", CmbHospital.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor is added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            CmbCity.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doctor where DoctorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor is deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doctor set DoctorName=@d1,DoctorSurname=@d2,DoctorBranch=@d3,DoctorPassword=@d5,CityName=@d6,HospitalName=@d7 where DoctorTC=@d4 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", MskTC.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.Parameters.AddWithValue("@d6", CmbCity.Text);
            komut.Parameters.AddWithValue("@d7", CmbHospital.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor is updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbHospital.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select HospitalName from Tbl_Hospital where CityName=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbCity.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbHospital.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }
    }
}
