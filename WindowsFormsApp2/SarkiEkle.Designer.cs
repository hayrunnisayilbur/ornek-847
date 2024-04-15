namespace WindowsFormsApp2
{
    partial class SarkiEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSarkiAdi = new System.Windows.Forms.TextBox();
            this.txtSanatci = new System.Windows.Forms.TextBox();
            this.cbFavori = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnSarkiEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şarkı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sanatçı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yıl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tür:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // txtSarkiAdi
            // 
            this.txtSarkiAdi.Location = new System.Drawing.Point(95, 64);
            this.txtSarkiAdi.Name = "txtSarkiAdi";
            this.txtSarkiAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSarkiAdi.TabIndex = 7;
            // 
            // txtSanatci
            // 
            this.txtSanatci.Location = new System.Drawing.Point(95, 100);
            this.txtSanatci.Name = "txtSanatci";
            this.txtSanatci.Size = new System.Drawing.Size(100, 20);
            this.txtSanatci.TabIndex = 8;
            // 
            // cbFavori
            // 
            this.cbFavori.AutoSize = true;
            this.cbFavori.Location = new System.Drawing.Point(95, 186);
            this.cbFavori.Name = "cbFavori";
            this.cbFavori.Size = new System.Drawing.Size(52, 17);
            this.cbFavori.TabIndex = 9;
            this.cbFavori.Text = "favori";
            this.cbFavori.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Eklenme Tarihi:";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(95, 137);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 20);
            this.txtYil.TabIndex = 12;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(361, 138);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(190, 20);
            this.dtpTarih.TabIndex = 14;
            // 
            // btnSarkiEkle
            // 
            this.btnSarkiEkle.Location = new System.Drawing.Point(27, 222);
            this.btnSarkiEkle.Name = "btnSarkiEkle";
            this.btnSarkiEkle.Size = new System.Drawing.Size(187, 42);
            this.btnSarkiEkle.TabIndex = 15;
            this.btnSarkiEkle.Text = "Şarkı Ekle";
            this.btnSarkiEkle.UseVisualStyleBackColor = true;
            this.btnSarkiEkle.Click += new System.EventHandler(this.btnSarkiEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Süre:";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(361, 67);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 21);
            this.cmbTur.TabIndex = 17;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(361, 100);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(121, 20);
            this.txtSure.TabIndex = 18;
            // 
            // SarkiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(559, 333);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSarkiEkle);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFavori);
            this.Controls.Add(this.txtSanatci);
            this.Controls.Add(this.txtSarkiAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SarkiEkle";
            this.Text = "SarkiEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSarkiAdi;
        private System.Windows.Forms.TextBox txtSanatci;
        private System.Windows.Forms.CheckBox cbFavori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnSarkiEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.TextBox txtSure;
    }
}