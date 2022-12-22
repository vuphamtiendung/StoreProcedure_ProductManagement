namespace StoreProcedure08
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
            this.components = new System.ComponentModel.Container();
            this.lsvListProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmtUpdateCost = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmtUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddCode = new System.Windows.Forms.TextBox();
            this.cbbItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTakeAll = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCodeProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmtUpdateCost.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvListProduct
            // 
            this.lsvListProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvListProduct.ContextMenuStrip = this.cmtUpdateCost;
            this.lsvListProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvListProduct.FullRowSelect = true;
            this.lsvListProduct.GridLines = true;
            this.lsvListProduct.HideSelection = false;
            this.lsvListProduct.Location = new System.Drawing.Point(380, 12);
            this.lsvListProduct.Name = "lsvListProduct";
            this.lsvListProduct.Size = new System.Drawing.Size(721, 443);
            this.lsvListProduct.TabIndex = 20;
            this.lsvListProduct.UseCompatibleStateImageBehavior = false;
            this.lsvListProduct.View = System.Windows.Forms.View.Details;
            this.lsvListProduct.SelectedIndexChanged += new System.EventHandler(this.lsvListProduct_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 218;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 186;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã danh mục";
            this.columnHeader4.Width = 139;
            // 
            // cmtUpdateCost
            // 
            this.cmtUpdateCost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmtUpdate});
            this.cmtUpdateCost.Name = "contextMenuStrip1";
            this.cmtUpdateCost.Size = new System.Drawing.Size(142, 26);
            // 
            // cmtUpdate
            // 
            this.cmtUpdate.Name = "cmtUpdate";
            this.cmtUpdate.Size = new System.Drawing.Size(141, 22);
            this.cmtUpdate.Text = "Cập nhật giá";
            this.cmtUpdate.Click += new System.EventHandler(this.cmtUpdate_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteProduct.Location = new System.Drawing.Point(244, 142);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(106, 32);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Xoá sản phẩm";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Location = new System.Drawing.Point(121, 142);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(106, 32);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(121, 114);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(229, 22);
            this.txtAddCost.TabIndex = 7;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(121, 86);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(229, 22);
            this.txtAddName.TabIndex = 6;
            // 
            // txtAddCode
            // 
            this.txtAddCode.Location = new System.Drawing.Point(121, 58);
            this.txtAddCode.Name = "txtAddCode";
            this.txtAddCode.Size = new System.Drawing.Size(229, 22);
            this.txtAddCode.TabIndex = 5;
            // 
            // cbbItem
            // 
            this.cbbItem.FormattingEnabled = true;
            this.cbbItem.Location = new System.Drawing.Point(121, 28);
            this.cbbItem.Name = "cbbItem";
            this.cbbItem.Size = new System.Drawing.Size(229, 24);
            this.cbbItem.TabIndex = 4;
            this.cbbItem.SelectedIndexChanged += new System.EventHandler(this.cbbItem_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTakeAll);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.txtCodeProduct);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 91);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // btnTakeAll
            // 
            this.btnTakeAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakeAll.Location = new System.Drawing.Point(244, 49);
            this.btnTakeAll.Name = "btnTakeAll";
            this.btnTakeAll.Size = new System.Drawing.Size(106, 32);
            this.btnTakeAll.TabIndex = 3;
            this.btnTakeAll.Text = "Take All";
            this.btnTakeAll.UseVisualStyleBackColor = true;
            this.btnTakeAll.Click += new System.EventHandler(this.btnTakeAll_Click);
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Location = new System.Drawing.Point(121, 49);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(106, 32);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtCodeProduct
            // 
            this.txtCodeProduct.Location = new System.Drawing.Point(121, 21);
            this.txtCodeProduct.Name = "txtCodeProduct";
            this.txtCodeProduct.Size = new System.Drawing.Size(229, 22);
            this.txtCodeProduct.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteProduct);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.txtAddCost);
            this.groupBox1.Controls.Add(this.txtAddName);
            this.groupBox1.Controls.Add(this.txtAddCode);
            this.groupBox1.Controls.Add(this.cbbItem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 183);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm - Xoá sản phẩm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 503);
            this.Controls.Add(this.lsvListProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmtUpdateCost.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvListProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip cmtUpdateCost;
        private System.Windows.Forms.ToolStripMenuItem cmtUpdate;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddCode;
        private System.Windows.Forms.ComboBox cbbItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTakeAll;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtCodeProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

