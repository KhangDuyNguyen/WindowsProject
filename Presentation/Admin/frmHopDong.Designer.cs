namespace Presentation.Admin
{
    partial class frmHopDong
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
            cbPhong = new ComboBox();
            cbThoiHan = new ComboBox();
            cbGiamGia = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cbPhong
            // 
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new Point(135, 27);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(151, 28);
            cbPhong.TabIndex = 0;
            // 
            // cbThoiHan
            // 
            cbThoiHan.FormattingEnabled = true;
            cbThoiHan.Location = new Point(137, 65);
            cbThoiHan.Name = "cbThoiHan";
            cbThoiHan.Size = new Size(151, 28);
            cbThoiHan.TabIndex = 1;
            // 
            // cbGiamGia
            // 
            cbGiamGia.FormattingEnabled = true;
            cbGiamGia.Location = new Point(140, 100);
            cbGiamGia.Name = "cbGiamGia";
            cbGiamGia.Size = new Size(151, 28);
            cbGiamGia.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(138, 141);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Luu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(cbGiamGia);
            Controls.Add(cbThoiHan);
            Controls.Add(cbPhong);
            Name = "frmHopDong";
            Text = "frmHopDong";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbPhong;
        private ComboBox cbThoiHan;
        private ComboBox cbGiamGia;
        private Button btnSave;
    }
}