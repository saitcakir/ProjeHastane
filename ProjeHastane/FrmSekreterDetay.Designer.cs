namespace ProjeHastane
{
    partial class FrmSekreterDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbHospital = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BntKaydet = new System.Windows.Forms.Button();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnListe = new System.Windows.Forms.Button();
            this.BtnBransPanel = new System.Windows.Forms.Button();
            this.BtnDoktorPanel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Info";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(182, 100);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(93, 28);
            this.LblAdSoyad.TabIndex = 18;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name Surname:";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(182, 55);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(144, 28);
            this.LblTC.TabIndex = 16;
            this.LblTC.Text = "00000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "TC No:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbHospital);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.CmbCity);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.BntKaydet);
            this.groupBox3.Controls.Add(this.CmbDoktor);
            this.groupBox3.Controls.Add(this.CmbBrans);
            this.groupBox3.Controls.Add(this.MskSaat);
            this.groupBox3.Controls.Add(this.MskTarih);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(348, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 535);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Panel";
            // 
            // CmbHospital
            // 
            this.CmbHospital.FormattingEnabled = true;
            this.CmbHospital.Location = new System.Drawing.Point(102, 181);
            this.CmbHospital.Name = "CmbHospital";
            this.CmbHospital.Size = new System.Drawing.Size(198, 36);
            this.CmbHospital.TabIndex = 50;
            this.CmbHospital.SelectedIndexChanged += new System.EventHandler(this.CmbHospital_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 28);
            this.label10.TabIndex = 49;
            this.label10.Text = "Hospital:";
            // 
            // CmbCity
            // 
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(102, 139);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(198, 36);
            this.CmbCity.TabIndex = 48;
            this.CmbCity.SelectedIndexChanged += new System.EventHandler(this.CmbCity_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 28);
            this.label11.TabIndex = 47;
            this.label11.Text = "City:";
            // 
            // BntKaydet
            // 
            this.BntKaydet.Location = new System.Drawing.Point(103, 336);
            this.BntKaydet.Name = "BntKaydet";
            this.BntKaydet.Size = new System.Drawing.Size(199, 50);
            this.BntKaydet.TabIndex = 46;
            this.BntKaydet.Text = "Save";
            this.BntKaydet.UseVisualStyleBackColor = true;
            this.BntKaydet.Click += new System.EventHandler(this.BntKaydet_Click);
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(102, 265);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(199, 36);
            this.CmbDoktor.TabIndex = 42;
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(102, 223);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(199, 36);
            this.CmbBrans.TabIndex = 41;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(101, 97);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(199, 36);
            this.MskSaat.TabIndex = 40;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(102, 56);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(199, 36);
            this.MskTarih.TabIndex = 39;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 37;
            this.label6.Text = "Doctor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Branch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "Date:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(674, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(654, 357);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branches";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(674, 375);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(654, 308);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(648, 273);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnListe);
            this.groupBox6.Controls.Add(this.BtnBransPanel);
            this.groupBox6.Controls.Add(this.BtnDoktorPanel);
            this.groupBox6.Location = new System.Drawing.Point(14, 553);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(654, 130);
            this.groupBox6.TabIndex = 50;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fast Access";
            // 
            // BtnListe
            // 
            this.BtnListe.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListe.Location = new System.Drawing.Point(319, 47);
            this.BtnListe.Name = "BtnListe";
            this.BtnListe.Size = new System.Drawing.Size(172, 50);
            this.BtnListe.TabIndex = 50;
            this.BtnListe.Text = "Appointment List";
            this.BtnListe.UseVisualStyleBackColor = true;
            this.BtnListe.Click += new System.EventHandler(this.BtnListe_Click);
            // 
            // BtnBransPanel
            // 
            this.BtnBransPanel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBransPanel.Location = new System.Drawing.Point(164, 47);
            this.BtnBransPanel.Name = "BtnBransPanel";
            this.BtnBransPanel.Size = new System.Drawing.Size(149, 50);
            this.BtnBransPanel.TabIndex = 49;
            this.BtnBransPanel.Text = "Branch Panel";
            this.BtnBransPanel.UseVisualStyleBackColor = true;
            this.BtnBransPanel.Click += new System.EventHandler(this.BtnBransPanel_Click);
            // 
            // BtnDoktorPanel
            // 
            this.BtnDoktorPanel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoktorPanel.Location = new System.Drawing.Point(5, 47);
            this.BtnDoktorPanel.Name = "BtnDoktorPanel";
            this.BtnDoktorPanel.Size = new System.Drawing.Size(149, 50);
            this.BtnDoktorPanel.TabIndex = 48;
            this.BtnDoktorPanel.Text = "Doctor Panel";
            this.BtnDoktorPanel.UseVisualStyleBackColor = true;
            this.BtnDoktorPanel.Click += new System.EventHandler(this.BtnDoktorPanel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1334, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 28);
            this.label5.TabIndex = 51;
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1403, 694);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSekreterDetay_FormClosing);
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.Button BntKaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnListe;
        private System.Windows.Forms.Button BtnBransPanel;
        private System.Windows.Forms.Button BtnDoktorPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbHospital;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.Label label11;
    }
}