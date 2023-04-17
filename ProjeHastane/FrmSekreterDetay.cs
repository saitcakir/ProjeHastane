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
    public partial class FrmSekreterDetay : Form
    {
        private int TimerValue;
        int MaxLimit = 180;
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;
            timer1.Enabled = true;
            timer1.Interval = 1000;

            LblTC.Text = TCnumara;
            //Ad Soyad
            SqlCommand komut1 = new SqlCommand("Select SecretaryNameSurname From Tbl_Secretary where SecretaryTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
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


            //Branşları DataGride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branch", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları Listeye Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName + ' ' + DoctorSurname) as 'Doctors', DoctorBranch from Tbl_Doctor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BranchName from Tbl_Branch", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void BntKaydet_Click(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;

            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Appointment(AppointmentDate,AppointmentTime,AppointmentBranch,AppointmentDoctor,CityName,HospitalName) values (@r1,@r2,@r3,@r4,@r5,@r6)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komutkaydet.Parameters.AddWithValue("@r5", CmbCity.Text);
            komutkaydet.Parameters.AddWithValue("@r6", CmbHospital.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Appointment is Created");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctor where DoctorBranch=@p1 and CityName=@p2 and HospitalName=@p3", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            komut3.Parameters.AddWithValue("@p2", CmbCity.Text);
            komut3.Parameters.AddWithValue("@p3", CmbHospital.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }



        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;

            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;

            FrmBrans frb = new FrmBrans();
            frb.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;

            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void FrmSekreterDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    FrmSekreterGiris frs = new FrmSekreterGiris();
                    frs.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerValue--;
            label5.Text = TimerValue.ToString();
            if (TimerValue == 0)
            {
                this.Hide();
                FrmSekreterGiris frm = new FrmSekreterGiris();
                frm.Show();
            }
        }

        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;

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

        private void CmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;

            CmbBrans.Items.Clear();
            SqlCommand komut2 = new SqlCommand("Select BranchName from Tbl_Branch", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

    
    }
}
