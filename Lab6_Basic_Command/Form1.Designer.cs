namespace Lab6_Basic_Command {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            btnLoad = new Button();
            chID = new ColumnHeader();
            lvCategory = new ListView();
            chName = new ColumnHeader();
            chType = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            txtType = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmDelete = new ToolStripMenuItem();
            tsmViewfood = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 129);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(114, 30);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Lấy danh sách";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // chID
            // 
            chID.Text = "Mã loại";
            chID.Width = 120;
            // 
            // lvCategory
            // 
            lvCategory.Columns.AddRange(new ColumnHeader[] { chID, chName, chType });
            lvCategory.ContextMenuStrip = contextMenuStrip1;
            lvCategory.FullRowSelect = true;
            lvCategory.Location = new Point(12, 165);
            lvCategory.MultiSelect = false;
            lvCategory.Name = "lvCategory";
            lvCategory.Size = new Size(818, 336);
            lvCategory.TabIndex = 1;
            lvCategory.UseCompatibleStateImageBehavior = false;
            lvCategory.View = View.Details;
            lvCategory.SelectedIndexChanged += lvCategory_SelectedIndexChanged;
            lvCategory.Click += lvCategory_Click;
            // 
            // chName
            // 
            chName.Text = "Tên loại món ăn";
            chName.Width = 400;
            // 
            // chType
            // 
            chType.Text = "Loại";
            chType.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Mã nhóm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên nhóm thức ăn:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Loại:";
            // 
            // txtName
            // 
            txtName.Location = new Point(172, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 23);
            txtName.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(172, 21);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(286, 23);
            txtID.TabIndex = 7;
            // 
            // txtType
            // 
            txtType.Location = new Point(172, 95);
            txtType.Name = "txtType";
            txtType.Size = new Size(286, 23);
            txtType.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(399, 129);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 30);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(530, 129);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 30);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Cập nhập";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(660, 129);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 30);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmDelete, tsmViewfood });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(200, 48);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // tsmDelete
            // 
            tsmDelete.Name = "tsmDelete";
            tsmDelete.Size = new Size(199, 22);
            tsmDelete.Text = "Xóa nhóm sản phẩm";
            tsmDelete.Click += tsmDelete_Click;
            // 
            // tsmViewfood
            // 
            tsmViewfood.Name = "tsmViewfood";
            tsmViewfood.Size = new Size(199, 22);
            tsmViewfood.Text = "Xem danh sách món ăn";
            tsmViewfood.Click += tsmViewfood_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 513);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtType);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvCategory);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private ColumnHeader chID;
        private ListView lvCategory;
        private ColumnHeader chName;
        private ColumnHeader chType;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtType;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmDelete;
        private ToolStripMenuItem tsmViewfood;
    }
}