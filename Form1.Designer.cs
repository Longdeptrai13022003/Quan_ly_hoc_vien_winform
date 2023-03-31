namespace Quan_ly_hoc_vien
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstvA = new System.Windows.Forms.ListView();
            this.lstvB = new System.Windows.Forms.ListView();
            this.btnOneRight = new System.Windows.Forms.Button();
            this.btnAllRight = new System.Windows.Forms.Button();
            this.btnOneLeft = new System.Windows.Forms.Button();
            this.btnAllLeft = new System.Windows.Forms.Button();
            this.lblSearchA = new System.Windows.Forms.Label();
            this.lblSearchB = new System.Windows.Forms.Label();
            this.txtSearchA = new System.Windows.Forms.TextBox();
            this.txtSearchB = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMSV = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(319, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý học viên";
            // 
            // lstvA
            // 
            this.lstvA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvA.GridLines = true;
            this.lstvA.HideSelection = false;
            this.lstvA.Location = new System.Drawing.Point(49, 180);
            this.lstvA.Name = "lstvA";
            this.lstvA.Size = new System.Drawing.Size(374, 343);
            this.lstvA.TabIndex = 1;
            this.lstvA.UseCompatibleStateImageBehavior = false;
            this.lstvA.View = System.Windows.Forms.View.Details;
            // 
            // lstvB
            // 
            this.lstvB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstvB.GridLines = true;
            this.lstvB.HideSelection = false;
            this.lstvB.Location = new System.Drawing.Point(510, 180);
            this.lstvB.Name = "lstvB";
            this.lstvB.Size = new System.Drawing.Size(378, 343);
            this.lstvB.TabIndex = 2;
            this.lstvB.UseCompatibleStateImageBehavior = false;
            this.lstvB.View = System.Windows.Forms.View.Details;
            // 
            // btnOneRight
            // 
            this.btnOneRight.Location = new System.Drawing.Point(429, 218);
            this.btnOneRight.Name = "btnOneRight";
            this.btnOneRight.Size = new System.Drawing.Size(75, 32);
            this.btnOneRight.TabIndex = 3;
            this.btnOneRight.Text = ">";
            this.btnOneRight.UseVisualStyleBackColor = true;
            this.btnOneRight.Click += new System.EventHandler(this.btnOneRight_Click);
            // 
            // btnAllRight
            // 
            this.btnAllRight.Location = new System.Drawing.Point(429, 278);
            this.btnAllRight.Name = "btnAllRight";
            this.btnAllRight.Size = new System.Drawing.Size(75, 32);
            this.btnAllRight.TabIndex = 4;
            this.btnAllRight.Text = ">>";
            this.btnAllRight.UseVisualStyleBackColor = true;
            this.btnAllRight.Click += new System.EventHandler(this.btnAllRight_Click);
            // 
            // btnOneLeft
            // 
            this.btnOneLeft.Location = new System.Drawing.Point(429, 337);
            this.btnOneLeft.Name = "btnOneLeft";
            this.btnOneLeft.Size = new System.Drawing.Size(75, 32);
            this.btnOneLeft.TabIndex = 5;
            this.btnOneLeft.Text = "<";
            this.btnOneLeft.UseVisualStyleBackColor = true;
            this.btnOneLeft.Click += new System.EventHandler(this.btnOneLeft_Click);
            // 
            // btnAllLeft
            // 
            this.btnAllLeft.Location = new System.Drawing.Point(429, 399);
            this.btnAllLeft.Name = "btnAllLeft";
            this.btnAllLeft.Size = new System.Drawing.Size(75, 32);
            this.btnAllLeft.TabIndex = 6;
            this.btnAllLeft.Text = "<<";
            this.btnAllLeft.UseVisualStyleBackColor = true;
            this.btnAllLeft.Click += new System.EventHandler(this.btnAllLeft_Click);
            // 
            // lblSearchA
            // 
            this.lblSearchA.AutoSize = true;
            this.lblSearchA.Location = new System.Drawing.Point(117, 571);
            this.lblSearchA.Name = "lblSearchA";
            this.lblSearchA.Size = new System.Drawing.Size(98, 22);
            this.lblSearchA.TabIndex = 7;
            this.lblSearchA.Text = "Tìm nhanh:";
            // 
            // lblSearchB
            // 
            this.lblSearchB.AutoSize = true;
            this.lblSearchB.Location = new System.Drawing.Point(615, 571);
            this.lblSearchB.Name = "lblSearchB";
            this.lblSearchB.Size = new System.Drawing.Size(98, 22);
            this.lblSearchB.TabIndex = 8;
            this.lblSearchB.Text = "Tìm nhanh:";
            // 
            // txtSearchA
            // 
            this.txtSearchA.Location = new System.Drawing.Point(221, 563);
            this.txtSearchA.Name = "txtSearchA";
            this.txtSearchA.Size = new System.Drawing.Size(159, 30);
            this.txtSearchA.TabIndex = 9;
            this.txtSearchA.TextChanged += new System.EventHandler(this.txtSearchA_TextChanged);
            // 
            // txtSearchB
            // 
            this.txtSearchB.Location = new System.Drawing.Point(729, 563);
            this.txtSearchB.Name = "txtSearchB";
            this.txtSearchB.Size = new System.Drawing.Size(159, 30);
            this.txtSearchB.TabIndex = 10;
            this.txtSearchB.TextChanged += new System.EventHandler(this.txtSearchB_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(813, 616);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 35);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(49, 142);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(49, 32);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(104, 142);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(100, 30);
            this.txtMSV.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 30);
            this.txtName.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(217, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Họ tên";
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Location = new System.Drawing.Point(100, 119);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(65, 22);
            this.lblMSV.TabIndex = 16;
            this.lblMSV.Text = "Mã SV";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã SV";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ tên";
            this.columnHeader3.Width = 249;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STT";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã SV";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Họ tên";
            this.columnHeader6.Width = 255;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(363, 119);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(62, 23);
            this.lblA.TabIndex = 17;
            this.lblA.Text = "Lớp A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(826, 118);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(62, 23);
            this.lblB.TabIndex = 18;
            this.lblB.Text = "Lớp B";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 663);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblMSV);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtSearchB);
            this.Controls.Add(this.txtSearchA);
            this.Controls.Add(this.lblSearchB);
            this.Controls.Add(this.lblSearchA);
            this.Controls.Add(this.btnAllLeft);
            this.Controls.Add(this.btnOneLeft);
            this.Controls.Add(this.btnAllRight);
            this.Controls.Add(this.btnOneRight);
            this.Controls.Add(this.lstvB);
            this.Controls.Add(this.lstvA);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Quản lý học viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lstvA;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstvB;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnOneRight;
        private System.Windows.Forms.Button btnAllRight;
        private System.Windows.Forms.Button btnOneLeft;
        private System.Windows.Forms.Button btnAllLeft;
        private System.Windows.Forms.Label lblSearchA;
        private System.Windows.Forms.Label lblSearchB;
        private System.Windows.Forms.TextBox txtSearchA;
        private System.Windows.Forms.TextBox txtSearchB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMSV;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
    }
}

