namespace Presentation
{
    partial class frmPhongTro
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
            dgvPhongTro = new DataGridView();
            txtTenPhong = new TextBox();
            numDienTich = new NumericUpDown();
            numGiaPhong = new NumericUpDown();
            cbTrangThai = new ComboBox();
            txtMoTa = new TextBox();
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            btnReload = new Button();
            label1 = new Label();
            txtMaPhong = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPhongTro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDienTich).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaPhong).BeginInit();
            SuspendLayout();
            // 
            // dgvPhongTro
            // 
            dgvPhongTro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhongTro.Location = new Point(12, 12);
            dgvPhongTro.Name = "dgvPhongTro";
            dgvPhongTro.ReadOnly = true;
            dgvPhongTro.RowHeadersWidth = 51;
            dgvPhongTro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhongTro.Size = new Size(1073, 526);
            dgvPhongTro.TabIndex = 0;
            dgvPhongTro.CellClick += dgvPhongTro_CellClick;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(1291, 193);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(125, 27);
            txtTenPhong.TabIndex = 2;
            // 
            // numDienTich
            // 
            numDienTich.Location = new Point(1285, 232);
            numDienTich.Name = "numDienTich";
            numDienTich.Size = new Size(150, 27);
            numDienTich.TabIndex = 3;
            // 
            // numGiaPhong
            // 
            numGiaPhong.Location = new Point(1287, 274);
            numGiaPhong.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numGiaPhong.Name = "numGiaPhong";
            numGiaPhong.Size = new Size(150, 27);
            numGiaPhong.TabIndex = 4;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Items.AddRange(new object[] { "Trống", "Đã Thuê" });
            cbTrangThai.Location = new Point(1273, 315);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(151, 28);
            cbTrangThai.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(1272, 363);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(180, 75);
            txtMoTa.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1258, 444);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Luu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1139, 196);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên Phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1139, 234);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 10;
            label3.Text = "Diện Tích";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1139, 274);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 11;
            label4.Text = "Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1139, 315);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 12;
            label5.Text = "Trạng Thái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1139, 363);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 13;
            label6.Text = "Mô Tả";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1358, 444);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1158, 444);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(1387, 479);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(94, 29);
            btnReload.TabIndex = 16;
            btnReload.Text = "Làm Mới";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1134, 161);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 8;
            label1.Text = "Mã Phòng";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(1285, 158);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(125, 27);
            txtMaPhong.TabIndex = 1;
            // 
            // frmPhongTro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 571);
            Controls.Add(btnReload);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtMoTa);
            Controls.Add(cbTrangThai);
            Controls.Add(numGiaPhong);
            Controls.Add(numDienTich);
            Controls.Add(txtTenPhong);
            Controls.Add(txtMaPhong);
            Controls.Add(dgvPhongTro);
            Name = "frmPhongTro";
            Text = "frmPhongTro";
            Load += frmPhongTro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhongTro).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDienTich).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhongTro;
        private TextBox txtTenPhong;
        private NumericUpDown numDienTich;
        private NumericUpDown numGiaPhong;
        private ComboBox cbTrangThai;
        private TextBox txtMoTa;
        private Button btnSave;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnReload;
        private Label label1;
        private TextBox txtMaPhong;
    }
}