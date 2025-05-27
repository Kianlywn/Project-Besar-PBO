namespace PBO_Besar.Menu.Menu_Admin
{
    partial class MenuAdmin
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
            btnKasir = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnKasir
            // 
            btnKasir.Location = new Point(405, 112);
            btnKasir.Name = "btnKasir";
            btnKasir.Size = new Size(203, 40);
            btnKasir.TabIndex = 0;
            btnKasir.Text = "Data Kasir";
            btnKasir.UseVisualStyleBackColor = true;
            btnKasir.Click += btnKasir_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(690, 359);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(203, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 479);
            Controls.Add(btnBack);
            Controls.Add(btnKasir);
            Name = "MenuAdmin";
            Text = "MenuAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKasir;
        private Button btnBack;
    }
}