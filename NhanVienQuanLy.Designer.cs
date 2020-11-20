
namespace RealEstateApp_HQT
{
    partial class NhanVienQuanLy
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
            this.cbxSelectTable = new System.Windows.Forms.ComboBox();
            this.grpViewTable = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.grpViewTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSelectTable
            // 
            this.cbxSelectTable.FormattingEnabled = true;
            this.cbxSelectTable.Items.AddRange(new object[] {
            "NhanVien",
            "KhachHang",
            "HopDong",
            "LoaiNha",
            "Nha",
            "NhanVien",
            "LuotXem",
            "ChuNha"});
            this.cbxSelectTable.Location = new System.Drawing.Point(13, 21);
            this.cbxSelectTable.Name = "cbxSelectTable";
            this.cbxSelectTable.Size = new System.Drawing.Size(145, 24);
            this.cbxSelectTable.TabIndex = 0;
            this.cbxSelectTable.SelectedIndexChanged += new System.EventHandler(this.cbxSelectTable_SelectedIndexChanged);
            // 
            // grpViewTable
            // 
            this.grpViewTable.Controls.Add(this.btnView);
            this.grpViewTable.Controls.Add(this.cbxSelectTable);
            this.grpViewTable.Location = new System.Drawing.Point(12, 12);
            this.grpViewTable.Name = "grpViewTable";
            this.grpViewTable.Size = new System.Drawing.Size(364, 71);
            this.grpViewTable.TabIndex = 1;
            this.grpViewTable.TabStop = false;
            this.grpViewTable.Text = "Xem/Chỉnh sửa bảng";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(224, 21);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(97, 24);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // NhanVienQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 548);
            this.Controls.Add(this.grpViewTable);
            this.Name = "NhanVienQuanLy";
            this.Text = "NhanVienQuanLy";
            this.grpViewTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSelectTable;
        private System.Windows.Forms.GroupBox grpViewTable;
        private System.Windows.Forms.Button btnView;
    }
}