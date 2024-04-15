namespace WindowsFormsApp2
{
    partial class FormTumSarkilar
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
            this.dgwSarkilar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSarkilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSarkilar
            // 
            this.dgwSarkilar.AllowUserToAddRows = false;
            this.dgwSarkilar.AllowUserToDeleteRows = false;
            this.dgwSarkilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSarkilar.Location = new System.Drawing.Point(12, 236);
            this.dgwSarkilar.Name = "dgwSarkilar";
            this.dgwSarkilar.ReadOnly = true;
            this.dgwSarkilar.Size = new System.Drawing.Size(776, 189);
            this.dgwSarkilar.TabIndex = 0;
            // 
            // FormTumSarkilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwSarkilar);
            this.Name = "FormTumSarkilar";
            this.Text = "FormTumSarkilar";
            this.Load += new System.EventHandler(this.FormTumSarkilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSarkilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSarkilar;
    }
}