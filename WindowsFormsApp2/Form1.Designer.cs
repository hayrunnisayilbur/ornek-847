namespace WindowsFormsApp2
{
    partial class Form1
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
            this.btnSarkiEkle = new System.Windows.Forms.Button();
            this.btnTumSarkilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSarkiEkle
            // 
            this.btnSarkiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSarkiEkle.Location = new System.Drawing.Point(30, 87);
            this.btnSarkiEkle.Name = "btnSarkiEkle";
            this.btnSarkiEkle.Size = new System.Drawing.Size(164, 102);
            this.btnSarkiEkle.TabIndex = 0;
            this.btnSarkiEkle.Text = "Şarkı Ekle";
            this.btnSarkiEkle.UseVisualStyleBackColor = true;
            this.btnSarkiEkle.Click += new System.EventHandler(this.btnSarkiEkle_Click);
            // 
            // btnTumSarkilar
            // 
            this.btnTumSarkilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumSarkilar.Location = new System.Drawing.Point(200, 87);
            this.btnTumSarkilar.Name = "btnTumSarkilar";
            this.btnTumSarkilar.Size = new System.Drawing.Size(165, 102);
            this.btnTumSarkilar.TabIndex = 1;
            this.btnTumSarkilar.Text = "Tum Şarkılar";
            this.btnTumSarkilar.UseVisualStyleBackColor = true;
            this.btnTumSarkilar.Click += new System.EventHandler(this.btnTumSarkilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 315);
            this.Controls.Add(this.btnTumSarkilar);
            this.Controls.Add(this.btnSarkiEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSarkiEkle;
        private System.Windows.Forms.Button btnTumSarkilar;
    }
}

