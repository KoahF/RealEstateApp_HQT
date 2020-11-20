
namespace RealEstateApp_HQT
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
            this.btnOpenNVQLCN = new System.Windows.Forms.Button();
            this.btnOpenNVGD = new System.Windows.Forms.Button();
            this.btnOpenNVS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenNVQLCN
            // 
            this.btnOpenNVQLCN.Location = new System.Drawing.Point(234, 111);
            this.btnOpenNVQLCN.Name = "btnOpenNVQLCN";
            this.btnOpenNVQLCN.Size = new System.Drawing.Size(262, 57);
            this.btnOpenNVQLCN.TabIndex = 0;
            this.btnOpenNVQLCN.Text = "Nhân viên quản lý chi nhánh";
            this.btnOpenNVQLCN.UseVisualStyleBackColor = true;
            this.btnOpenNVQLCN.Click += new System.EventHandler(this.btnOpenNVQLCN_Click);
            // 
            // btnOpenNVGD
            // 
            this.btnOpenNVGD.Location = new System.Drawing.Point(148, 223);
            this.btnOpenNVGD.Name = "btnOpenNVGD";
            this.btnOpenNVGD.Size = new System.Drawing.Size(167, 30);
            this.btnOpenNVGD.TabIndex = 1;
            this.btnOpenNVGD.Text = "Nhân viên giao dịch";
            this.btnOpenNVGD.UseVisualStyleBackColor = true;
            this.btnOpenNVGD.Click += new System.EventHandler(this.btnOpenNVGD_Click);
            // 
            // btnOpenNVS
            // 
            this.btnOpenNVS.Location = new System.Drawing.Point(413, 223);
            this.btnOpenNVS.Name = "btnOpenNVS";
            this.btnOpenNVS.Size = new System.Drawing.Size(172, 30);
            this.btnOpenNVS.TabIndex = 3;
            this.btnOpenNVS.Text = "Nhân viên sale";
            this.btnOpenNVS.UseVisualStyleBackColor = true;
            this.btnOpenNVS.Click += new System.EventHandler(this.btnOpenNVS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vui lòng chọn loại người dùng để đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenNVS);
            this.Controls.Add(this.btnOpenNVGD);
            this.Controls.Add(this.btnOpenNVQLCN);
            this.Name = "Form1";
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenNVQLCN;
        private System.Windows.Forms.Button btnOpenNVGD;
        private System.Windows.Forms.Button btnOpenNVS;
        private System.Windows.Forms.Label label1;
    }
}

