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
using System.Reflection.Emit;


namespace ProjeHastane
{
    public partial class FrmDoktorDetay : Form
    {
        private int TimerValue;
        int MaxLimit = 180;
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;
            timer1.Enabled = true;
            timer1.Interval = 1000;

            LblTC.Text = TC;
            //Doktor Ad Soyad
            SqlCommand komut = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctor where DoctorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Listesi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointment where AppointmentDoctor='" + LblAdSoyad.Text +"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;

            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TCNO = LblTC.Text;
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            TimerValue = MaxLimit;

            FrmDuyurular fr =new FrmDuyurular();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TimerValue = MaxLimit;

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void FrmDoktorDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerValue = MaxLimit;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    FrmDoktorGiris frd = new FrmDoktorGiris();
                    frd.Show();
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
            label1.Text = TimerValue.ToString();
            if (TimerValue == 0)
            {
                this.Hide();
                FrmDoktorGiris frm = new FrmDoktorGiris();
                frm.Show();
            }
        }
    }
}
