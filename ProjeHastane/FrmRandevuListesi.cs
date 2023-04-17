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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();

        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select * from Tbl_Appointment", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());

            SqlCommand komut = new SqlCommand("update Tbl_Appointment set AppointmentState=0  where Appointmentid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id.ToString());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Appointment is canceled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
