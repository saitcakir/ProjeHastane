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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace ProjeHastane
{
    public partial class FrmHastaDetay : Form
    {
        private int TimerValue;
        int MaxLimit = 180;
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private async void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;
            timer1.Enabled = true;
            timer1.Interval = 1000;

            LblTC.Text = tc;

            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select PatientName,PatientSurname from Tbl_Patient where PatientTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            getdatagridview1();

            //Şehir Çekme

            SqlCommand komut4 = new SqlCommand("Select CityName from Tbl_City", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                CmbCity.Items.Add(dr4[0]);
            }
            bgl.baglanti().Close();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt16(row.Cells[5].Value) == 1)
                {
                    row.Cells[5].Style.BackColor = System.Drawing.Color.Green;
                }
                if (Convert.ToInt16(row.Cells[5].Value) == 0)
                {
                    row.Cells[5].Style.BackColor = System.Drawing.Color.Red;
                }
            }

            //Randevu iptal Çekme
            await Task.Delay(3000);
            SqlCommand komut5 = new SqlCommand("Select * from Tbl_Appointment where AppointmentState=0 and PatientTC=" + tc + " and  AppointmentNotification IS NULL ", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            string notid = "";
            if (dr5.HasRows)
            {
                string patientNotification = $"There are some appointments canceled. \n Related Appointmnet Id(s):\n";
                int flag = 0;
                while (dr5.Read())
                {
                    if (flag == 0)
                    {
                        flag = 1;
                    }
                    else
                    {
                        notid += ",";
                    }
                    patientNotification += dr5[0] + "\n";
                    notid += dr5[0];
                }
                MessageBox.Show(patientNotification);
                SqlCommand komut6 = new SqlCommand("update Tbl_Appointment set AppointmentNotification=1 where Appointmentid  in (" + notid + ")", bgl.baglanti());
                komut6.ExecuteNonQuery();
                bgl.baglanti().Close();
                getdatagridview1();       
            }
        }

        public void getdatagridview1()
        {
            //Randevu Geçmiş
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointment where PatientTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;
            getdatagridview2();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToInt16(row.Cells[5].Value) == 0)
                {
                    row.Cells[5].Style.BackColor = System.Drawing.Color.Green;
                }

            }
        }

        private void getdatagridview2()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointment where AppointmentBranch=N'" + CmbBrans.Text + "' AND AppointmentDoctor=N'" + CmbDoktor.Text + "' AND HospitalName=N'" + CmbHospital.Text + "' AND CityName=N'" + CmbCity.Text + "' and AppointmentState=0 and PatientTC IS NULL", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TimerValue = MaxLimit;

            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = LblTC.Text;
            fr.Show();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TimerValue = MaxLimit;

            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;

            SqlCommand komut = new SqlCommand("update Tbl_Appointment set AppointmentState=1,PatientTC=@p1,PatientComplaint=@p2  where Appointmentid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Appointment is taken.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            getdatagridview2();
            getdatagridview1();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt16(row.Cells[5].Value) == 1)
                {
                    row.Cells[5].Style.BackColor = System.Drawing.Color.Green;
                }
                if (Convert.ToInt16(row.Cells[5].Value) == 0)
                {
                    row.Cells[5].Style.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void FrmHastaDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    FrmHastaGiris frh = new FrmHastaGiris();
                    frh.Show();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerValue--;
            label9.Text = TimerValue.ToString();
            if (TimerValue == 0)
            {
                this.Hide();
                FrmHastaGiris frm = new FrmHastaGiris();
                frm.Show();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
