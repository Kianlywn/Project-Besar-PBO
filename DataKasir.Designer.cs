namespace PBO_Besar.Menu.Menu_Admin.Data_Kasir
{
    partial class DataKasir
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
            btnEdit = new Button();
            btnTambah = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            dgvKasir = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKasir).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(719, 71);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(222, 39);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(719, 168);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(222, 39);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(719, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(222, 39);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(719, 390);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(222, 39);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvKasir
            // 
            dgvKasir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKasir.Location = new Point(25, 39);
            dgvKasir.Name = "dgvKasir";
            dgvKasir.RowHeadersWidth = 51;
            dgvKasir.Size = new Size(640, 410);
            dgvKasir.TabIndex = 4;
            // 
            // DataKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 495);
            Controls.Add(dgvKasir);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnTambah);
            Controls.Add(btnEdit);
            Name = "DataKasir";
            Text = "DataKasir";
            ((System.ComponentModel.ISupportInitialize)dgvKasir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEdit;
        private Button btnTambah;
        private Button btnDelete;
        private Button btnBack;
        private DataGridView dgvKasir;
    }
}