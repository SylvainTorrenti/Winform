namespace _02FenetreModale
{
    partial class frmFille
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
            btYes = new Button();
            btCancel = new Button();
            tbFrmFille = new TextBox();
            SuspendLayout();
            // 
            // btYes
            // 
            btYes.Location = new Point(59, 169);
            btYes.Name = "btYes";
            btYes.Size = new Size(100, 46);
            btYes.TabIndex = 0;
            btYes.Text = "Valider";
            btYes.UseVisualStyleBackColor = true;
            btYes.Click += btYes_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(310, 169);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(100, 46);
            btCancel.TabIndex = 1;
            btCancel.Text = "Annuler";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // tbFrmFille
            // 
            tbFrmFille.Location = new Point(22, 40);
            tbFrmFille.Name = "tbFrmFille";
            tbFrmFille.Size = new Size(430, 23);
            tbFrmFille.TabIndex = 2;
            // 
            // frmFille
            // 
            AcceptButton = btYes;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            CancelButton = btCancel;
            ClientSize = new Size(461, 238);
            Controls.Add(tbFrmFille);
            Controls.Add(btCancel);
            Controls.Add(btYes);
            Name = "frmFille";
            Text = "frmFille";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btYes;
        private Button btCancel;
        internal TextBox tbFrmFille;
    }
}