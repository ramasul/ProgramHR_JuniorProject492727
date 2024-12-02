namespace JunproRama_492727
{
    partial class AplikasiHR
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_karyawan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_karyawan = new System.Windows.Forms.TextBox();
            this.cb_departemen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_karyawan
            // 
            this.lbl_karyawan.AutoSize = true;
            this.lbl_karyawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_karyawan.Location = new System.Drawing.Point(23, 96);
            this.lbl_karyawan.Name = "lbl_karyawan";
            this.lbl_karyawan.Size = new System.Drawing.Size(141, 20);
            this.lbl_karyawan.TabIndex = 1;
            this.lbl_karyawan.Text = "Nama Karyawan :";
            this.lbl_karyawan.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Karyawan :";
            // 
            // tb_karyawan
            // 
            this.tb_karyawan.Location = new System.Drawing.Point(170, 98);
            this.tb_karyawan.Name = "tb_karyawan";
            this.tb_karyawan.Size = new System.Drawing.Size(234, 20);
            this.tb_karyawan.TabIndex = 3;
            // 
            // cb_departemen
            // 
            this.cb_departemen.FormattingEnabled = true;
            this.cb_departemen.Location = new System.Drawing.Point(171, 129);
            this.cb_departemen.Name = "cb_departemen";
            this.cb_departemen.Size = new System.Drawing.Size(233, 21);
            this.cb_departemen.TabIndex = 4;
            // 
            // AplikasiHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_departemen);
            this.Controls.Add(this.tb_karyawan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_karyawan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AplikasiHR";
            this.Text = "AplikasiHR";
            this.Load += new System.EventHandler(this.AplikasiHR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_karyawan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_karyawan;
        private System.Windows.Forms.ComboBox cb_departemen;
    }
}

