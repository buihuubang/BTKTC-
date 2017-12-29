namespace BTKT57132300
{
    partial class frmUpdateCars
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
            this.txtBienSoXe = new System.Windows.Forms.TextBox();
            this.txtHangSanXuat = new System.Windows.Forms.TextBox();
            this.txtTongSoGhe = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgCars = new System.Windows.Forms.DataGridView();
            this.qLXEDataSet = new BTKT57132300.QLXEDataSet();
            this.xeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xeTableAdapter = new BTKT57132300.QLXEDataSetTableAdapters.XeTableAdapter();
            this.maXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienSoXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangSanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoGheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhập xe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Biển số xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hãng sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng số ghế";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(116, 36);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(123, 20);
            this.txtMaXe.TabIndex = 5;
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.Location = new System.Drawing.Point(116, 63);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.Size = new System.Drawing.Size(123, 20);
            this.txtBienSoXe.TabIndex = 6;
            // 
            // txtHangSanXuat
            // 
            this.txtHangSanXuat.Location = new System.Drawing.Point(116, 89);
            this.txtHangSanXuat.Name = "txtHangSanXuat";
            this.txtHangSanXuat.Size = new System.Drawing.Size(123, 20);
            this.txtHangSanXuat.TabIndex = 7;
            // 
            // txtTongSoGhe
            // 
            this.txtTongSoGhe.Location = new System.Drawing.Point(116, 115);
            this.txtTongSoGhe.Name = "txtTongSoGhe";
            this.txtTongSoGhe.Size = new System.Drawing.Size(123, 20);
            this.txtTongSoGhe.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(309, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(309, 61);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(309, 87);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 11;
            this.btnFix.Text = "SỬA";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(309, 113);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgCars
            // 
            this.dgCars.AutoGenerateColumns = false;
            this.dgCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maXeDataGridViewTextBoxColumn,
            this.bienSoXeDataGridViewTextBoxColumn,
            this.hangSanXuatDataGridViewTextBoxColumn,
            this.tongSoGheDataGridViewTextBoxColumn});
            this.dgCars.DataSource = this.xeBindingSource;
            this.dgCars.Location = new System.Drawing.Point(13, 155);
            this.dgCars.Name = "dgCars";
            this.dgCars.Size = new System.Drawing.Size(443, 108);
            this.dgCars.TabIndex = 13;
            // 
            // qLXEDataSet
            // 
            this.qLXEDataSet.DataSetName = "QLXEDataSet";
            this.qLXEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xeBindingSource
            // 
            this.xeBindingSource.DataMember = "Xe";
            this.xeBindingSource.DataSource = this.qLXEDataSet;
            // 
            // xeTableAdapter
            // 
            this.xeTableAdapter.ClearBeforeFill = true;
            // 
            // maXeDataGridViewTextBoxColumn
            // 
            this.maXeDataGridViewTextBoxColumn.DataPropertyName = "MaXe";
            this.maXeDataGridViewTextBoxColumn.HeaderText = "MaXe";
            this.maXeDataGridViewTextBoxColumn.Name = "maXeDataGridViewTextBoxColumn";
            // 
            // bienSoXeDataGridViewTextBoxColumn
            // 
            this.bienSoXeDataGridViewTextBoxColumn.DataPropertyName = "BienSoXe";
            this.bienSoXeDataGridViewTextBoxColumn.HeaderText = "BienSoXe";
            this.bienSoXeDataGridViewTextBoxColumn.Name = "bienSoXeDataGridViewTextBoxColumn";
            // 
            // hangSanXuatDataGridViewTextBoxColumn
            // 
            this.hangSanXuatDataGridViewTextBoxColumn.DataPropertyName = "HangSanXuat";
            this.hangSanXuatDataGridViewTextBoxColumn.HeaderText = "HangSanXuat";
            this.hangSanXuatDataGridViewTextBoxColumn.Name = "hangSanXuatDataGridViewTextBoxColumn";
            // 
            // tongSoGheDataGridViewTextBoxColumn
            // 
            this.tongSoGheDataGridViewTextBoxColumn.DataPropertyName = "TongSoGhe";
            this.tongSoGheDataGridViewTextBoxColumn.HeaderText = "TongSoGhe";
            this.tongSoGheDataGridViewTextBoxColumn.Name = "tongSoGheDataGridViewTextBoxColumn";
            // 
            // frmUpdateCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 275);
            this.Controls.Add(this.dgCars);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTongSoGhe);
            this.Controls.Add(this.txtHangSanXuat);
            this.Controls.Add(this.txtBienSoXe);
            this.Controls.Add(this.txtMaXe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateCars";
            this.Text = "frmUpdateCars";
            this.Load += new System.EventHandler(this.frmUpdateCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLXEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtBienSoXe;
        private System.Windows.Forms.TextBox txtHangSanXuat;
        private System.Windows.Forms.TextBox txtTongSoGhe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgCars;
        private QLXEDataSet qLXEDataSet;
        private System.Windows.Forms.BindingSource xeBindingSource;
        //private QLXEDataSetTableAdapters.XeTableAdapter xeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienSoXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangSanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoGheDataGridViewTextBoxColumn;
    }
}