namespace Phacmarcity_ADO.NET
{
    partial class Frm_Medicine
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
            TextBox textBox2;
            btnSearch = new Button();
            btnSave = new Button();
            label13 = new Label();
            label11 = new Label();
            picHangSX = new PictureBox();
            picNCC = new PictureBox();
            btnEdit = new Button();
            btnDelete = new Button();
            label9 = new Label();
            txtSoLuong = new TextBox();
            txtMaNhanVien = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            txtMaNCC = new Label();
            dgvThuoc = new DataGridView();
            btnUpdate = new Button();
            btnAdd = new Button();
            label3 = new Label();
            txt = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label16 = new Label();
            cbxTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            label19 = new Label();
            label17 = new Label();
            pnlMain = new Panel();
            pnlSearch = new Panel();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picHangSX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNCC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).BeginInit();
            panel1.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(3, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 193;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkCyan;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(289, 725);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 51);
            btnSearch.TabIndex = 192;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkCyan;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(289, 660);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 51);
            btnSave.TabIndex = 191;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkCyan;
            label13.Location = new Point(393, 115);
            label13.Name = "label13";
            label13.Size = new Size(148, 28);
            label13.TabIndex = 186;
            label13.Text = "Hãng sản xuất";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkCyan;
            label11.Location = new Point(110, 115);
            label11.Name = "label11";
            label11.Size = new Size(142, 28);
            label11.TabIndex = 184;
            label11.Text = "Nhà cung cấp";
            // 
            // picHangSX
            // 
            picHangSX.BorderStyle = BorderStyle.FixedSingle;
            picHangSX.Image = Properties.Resources.production;
            picHangSX.Location = new Point(311, 115);
            picHangSX.Name = "picHangSX";
            picHangSX.Size = new Size(63, 43);
            picHangSX.SizeMode = PictureBoxSizeMode.Zoom;
            picHangSX.TabIndex = 182;
            picHangSX.TabStop = false;
            picHangSX.Click += picHangSX_Click;
            // 
            // picNCC
            // 
            picNCC.BorderStyle = BorderStyle.FixedSingle;
            picNCC.Image = Properties.Resources.nha_cung_cap;
            picNCC.Location = new Point(41, 115);
            picNCC.Name = "picNCC";
            picNCC.Size = new Size(63, 43);
            picNCC.SizeMode = PictureBoxSizeMode.Zoom;
            picNCC.TabIndex = 180;
            picNCC.TabStop = false;
            picNCC.Click += picNCC_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkCyan;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(160, 725);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 51);
            btnEdit.TabIndex = 179;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkCyan;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(32, 725);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 51);
            btnDelete.TabIndex = 178;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkCyan;
            label9.Location = new Point(31, 401);
            label9.Name = "label9";
            label9.Size = new Size(114, 28);
            label9.TabIndex = 173;
            label9.Text = "Công dụng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(4, 172);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(169, 27);
            txtSoLuong.TabIndex = 172;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaNhanVien.Location = new Point(3, 46);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(169, 27);
            txtMaNhanVien.TabIndex = 168;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 796);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 27);
            panel2.TabIndex = 167;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(430, 35);
            label1.Name = "label1";
            label1.Size = new Size(400, 31);
            label1.TabIndex = 0;
            label1.Text = "Pharmacy Managerment Version 1.0";
            // 
            // txtMaNCC
            // 
            txtMaNCC.AutoSize = true;
            txtMaNCC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaNCC.ForeColor = Color.DarkCyan;
            txtMaNCC.Location = new Point(31, 318);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(125, 28);
            txtMaNCC.TabIndex = 170;
            txtMaNCC.Text = "Mã hãng SX";
            // 
            // dgvThuoc
            // 
            dgvThuoc.BackgroundColor = SystemColors.ControlLight;
            dgvThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThuoc.GridColor = Color.White;
            dgvThuoc.Location = new Point(447, 240);
            dgvThuoc.Name = "dgvThuoc";
            dgvThuoc.RowHeadersWidth = 51;
            dgvThuoc.RowTemplate.Height = 29;
            dgvThuoc.Size = new Size(826, 506);
            dgvThuoc.TabIndex = 166;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkCyan;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(160, 660);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 51);
            btnUpdate.TabIndex = 165;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkCyan;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(31, 660);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 51);
            btnAdd.TabIndex = 164;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(31, 359);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 158;
            label3.Text = "Mã nhà cung cấp";
            // 
            // txt
            // 
            txt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt.Location = new Point(3, 3);
            txt.Name = "txt";
            txt.Size = new Size(169, 27);
            txt.TabIndex = 156;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 109);
            panel1.TabIndex = 155;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(3, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 194;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(31, 236);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 195;
            label2.Text = "Mã thuốc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(31, 278);
            label7.Name = "label7";
            label7.Size = new Size(105, 28);
            label7.TabIndex = 196;
            label7.Text = "Tên thuốc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(30, 448);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 198;
            label4.Text = "Ghi chú";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(2, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 27);
            textBox3.TabIndex = 197;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.Control;
            label16.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkCyan;
            label16.Location = new Point(796, 177);
            label16.Name = "label16";
            label16.Size = new Size(129, 50);
            label16.TabIndex = 190;
            label16.Text = "Thuốc";
            // 
            // cbxTimKiem
            // 
            cbxTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTimKiem.FormattingEnabled = true;
            cbxTimKiem.Items.AddRange(new object[] { "Mã nhân viên", "Tên nhân viên", "Bộ phận", "Số điện thoại", "Ngày sinh", "Ngày vào làm" });
            cbxTimKiem.Location = new Point(3, 3);
            cbxTimKiem.Name = "cbxTimKiem";
            cbxTimKiem.Size = new Size(169, 28);
            cbxTimKiem.TabIndex = 203;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(4, 49);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(169, 27);
            txtTimKiem.TabIndex = 202;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.DarkCyan;
            label19.Location = new Point(135, 528);
            label19.Name = "label19";
            label19.Size = new Size(0, 28);
            label19.TabIndex = 201;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.DarkCyan;
            label17.Location = new Point(30, 503);
            label17.Name = "label17";
            label17.Size = new Size(100, 28);
            label17.TabIndex = 200;
            label17.Text = "Tìm kiếm";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(txt);
            pnlMain.Controls.Add(txtMaNhanVien);
            pnlMain.Controls.Add(txtSoLuong);
            pnlMain.Controls.Add(textBox2);
            pnlMain.Controls.Add(textBox1);
            pnlMain.Controls.Add(textBox3);
            pnlMain.Location = new Point(208, 236);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(184, 251);
            pnlMain.TabIndex = 204;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(cbxTimKiem);
            pnlSearch.Controls.Add(txtTimKiem);
            pnlSearch.Location = new Point(208, 488);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(180, 88);
            pnlSearch.TabIndex = 205;
            // 
            // Frm_Medicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 823);
            Controls.Add(pnlSearch);
            Controls.Add(pnlMain);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(picHangSX);
            Controls.Add(picNCC);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(txtMaNCC);
            Controls.Add(dgvThuoc);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Frm_Medicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thuốc";
            Load += Frm_Medicine_Load;
            ((System.ComponentModel.ISupportInitialize)picHangSX).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNCC).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Button btnSave;
        private Label label13;
        private Label label11;
        private PictureBox picHangSX;
        private PictureBox picNCC;
        private Button btnEdit;
        private Button btnDelete;
        private Label label9;
        private TextBox txtSoLuong;
        private ComboBox comboBox1;
        private Label txtTenThuoc;
        private TextBox txtMaNhanVien;
        private Panel panel2;
        private Label label1;
        private Label txtMaNCC;
        private DataGridView dgvThuoc;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox txtMaThuoc;
        private Label label3;
        private TextBox txt;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Label label7;
        private Label label4;
        private TextBox textBox3;
        private Label label16;
        private ComboBox cbxTimKiem;
        private TextBox txtTimKiem;
        private Label label19;
        private Label label17;
        private Panel pnlMain;
        private Panel pnlSearch;
    }
}