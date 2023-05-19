namespace Lab6_Basic_Command {
    partial class FoodForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dgvFood = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            SuspendLayout();
            // 
            // dgvFood
            // 
            dgvFood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new Point(-1, -1);
            dgvFood.Name = "dgvFood";
            dgvFood.RowTemplate.Height = 25;
            dgvFood.Size = new Size(802, 453);
            dgvFood.TabIndex = 0;
            dgvFood.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvFood);
            Name = "FoodForm";
            Text = "FoodForm";
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFood;
    }
}