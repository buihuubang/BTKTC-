namespace BTKT57132300
{
    partial class frmUpdateTrip
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtTaiXe = new System.Windows.Forms.TextBox();
            this.txtNoiDen = new System.Windows.Forms.TextBox();
            this.txtSoVe = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgTrip = new System.Windows.Forms.DataGridView();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soVeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLXEDataSet = new BTKT57132300.QLXEDataSet();
            this.chuyenXeTableAdapter = new BTKT57132300.QLXEDataSetTableAdapters.ChuyenXeTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.DateVal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenXeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhập chuyến xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã xe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài xế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nơi đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số vé";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(88, 46);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(148, 20);
            this.txtMaXe.TabIndex = 6;
            // 
            // txtTaiXe
            // 
            this.txtTaiXe.Location = new System.Drawing.Point(88, 68);
            this.txtTaiXe.Name = "txtTaiXe";
            this.txtTaiXe.Size = new System.Drawing.Size(148, 20);
            this.txtTaiXe.TabIndex = 7;
            // 
            // txtNoiDen
            // 
            this.txtNoiDen.Location = new System.Drawing.Point(88, 92);
            this.txtNoiDen.Name = "txtNoiDen";
            this.txtNoiDen.Size = new System.Drawing.Size(148, 20);
            this.txtNoiDen.TabIndex = 8;
            // 
            // txtSoVe
            // 
            this.txtSoVe.Location = new System.Drawing.Point(88, 115);
            this.txtSoVe.Name = "txtSoVe";
            this.txtSoVe.Size = new System.Drawing.Size(148, 20);
            this.txtSoVe.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(264, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(264, 113);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 12;
            this.btnFix.Text = "SỬA";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(369, 113);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dgTrip
            // 
            this.dgTrip.AutoGenerateColumns = false;
            this.dgTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayDataGridViewTextBoxColumn,
            this.maXeDataGridViewTextBoxColumn,
            this.taiXeDataGridViewTextBoxColumn,
            this.noiDenDataGridViewTextBoxColumn,
            this.soVeDataGridViewTextBoxColumn});
            this.dgTrip.DataSource = this.chuyenXeBindingSource;
            this.dgTrip.Location = new System.Drawing.Point(15, 161);
            this.dgTrip.Name = "dgTrip";
            this.dgTrip.Size = new System.Drawing.Size(515, 109);
            this.dgTrip.TabIndex = 14;
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "Ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngay";
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            // 
            // maXeDataGridViewTextBoxColumn
            // 
            this.maXeDataGridViewTextBoxColumn.DataPropertyName = "MaXe";
            this.maXeDataGridViewTextBoxColumn.HeaderText = "MaXe";
            this.maXeDataGridViewTextBoxColumn.Name = "maXeDataGridViewTextBoxColumn";
            // 
            // taiXeDataGridViewTextBoxColumn
            // 
            this.taiXeDataGridViewTextBoxColumn.DataPropertyName = "TaiXe";
            this.taiXeDataGridViewTextBoxColumn.HeaderText = "TaiXe";
            this.taiXeDataGridViewTextBoxColumn.Name = "taiXeDataGridViewTextBoxColumn";
            // 
            // noiDenDataGridViewTextBoxColumn
            // 
            this.noiDenDataGridViewTextBoxColumn.DataPropertyName = "NoiDen";
            this.noiDenDataGridViewTextBoxColumn.HeaderText = "NoiDen";
            this.noiDenDataGridViewTextBoxColumn.Name = "noiDenDataGridViewTextBoxColumn";
            // 
            // soVeDataGridViewTextBoxColumn
            // 
            this.soVeDataGridViewTextBoxColumn.DataPropertyName = "SoVe";
            this.soVeDataGridViewTextBoxColumn.HeaderText = "SoVe";
            this.soVeDataGridViewTextBoxColumn.Name = "soVeDataGridViewTextBoxColumn";
            // 
            // chuyenXeBindingSource
            // 
            this.chuyenXeBindingSource.DataMember = "ChuyenXe";
            this.chuyenXeBindingSource.DataSource = this.qLXEDataSet;
            // 
            // qLXEDataSet
            // 
            this.qLXEDataSet.DataSetName = "QLXEDataSet";
            this.qLXEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chuyenXeTableAdapter
            // 
            this.chuyenXeTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày";
            // 
            // DateVal
            // 
            this.DateVal.Location = new System.Drawing.Point(299, 47);
            this.DateVal.Name = "DateVal";
            this.DateVal.Size = new System.Drawing.Size(145, 20);
            this.DateVal.TabIndex = 17;
            // 
            // frmUpdateTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 282);
            this.Controls.Add(this.DateVal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgTrip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSoVe);
            this.Controls.Add(this.txtNoiDen);
            this.Controls.Add(this.txtTaiXe);
            this.Controls.Add(this.txtMaXe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateTrip";
            this.Text = "frmUpdateTrip";
            this.Load += new System.EventHandler(this.frmUpdateTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenXeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtTaiXe;
        private System.Windows.Forms.TextBox txtNoiDen;
        private System.Windows.Forms.TextBox txtSoVe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgTrip;
        private QLXEDataSet qLXEDataSet;
        private System.Windows.Forms.BindingSource chuyenXeBindingSource;
        private QLXEDataSetTableAdapters.ChuyenXeTableAdapter chuyenXeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soVeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateVal;
    }
}