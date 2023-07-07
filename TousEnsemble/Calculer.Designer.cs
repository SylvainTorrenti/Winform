namespace TousEnsemble
{
    partial class Calculer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculer));
            tbNb1 = new TextBox();
            tbNb2 = new TextBox();
            tbResult = new TextBox();
            lbAdition = new Label();
            lbLine = new Label();
            btCancel = new Button();
            btResult = new Button();
            SuspendLayout();
            // 
            // tbNb1
            // 
            tbNb1.Location = new Point(280, 21);
            tbNb1.Name = "tbNb1";
            tbNb1.Size = new Size(339, 23);
            tbNb1.TabIndex = 0;
            // 
            // tbNb2
            // 
            tbNb2.Location = new Point(280, 75);
            tbNb2.Name = "tbNb2";
            tbNb2.Size = new Size(339, 23);
            tbNb2.TabIndex = 1;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(280, 165);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(339, 23);
            tbResult.TabIndex = 2;
            // 
            // lbAdition
            // 
            lbAdition.AutoSize = true;
            lbAdition.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbAdition.Location = new Point(231, 75);
            lbAdition.Name = "lbAdition";
            lbAdition.Size = new Size(25, 25);
            lbAdition.TabIndex = 3;
            lbAdition.Text = "+";
            // 
            // lbLine
            // 
            lbLine.AutoSize = true;
            lbLine.Location = new Point(280, 123);
            lbLine.Name = "lbLine";
            lbLine.Size = new Size(342, 15);
            lbLine.TabIndex = 4;
            lbLine.Text = "___________________________________________________________________";
            // 
            // btCancel
            // 
            btCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCancel.Location = new Point(634, 21);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(35, 23);
            btCancel.TabIndex = 5;
            btCancel.Text = "CE";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btResult
            // 
            btResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btResult.Location = new Point(231, 165);
            btResult.Name = "btResult";
            btResult.Size = new Size(24, 23);
            btResult.TabIndex = 6;
            btResult.Text = "=";
            btResult.UseVisualStyleBackColor = true;
            // 
            // Calculer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 242);
            Controls.Add(btResult);
            Controls.Add(btCancel);
            Controls.Add(lbLine);
            Controls.Add(lbAdition);
            Controls.Add(tbResult);
            Controls.Add(tbNb2);
            Controls.Add(tbNb1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculer";
            Text = "Calculer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNb1;
        private TextBox tbNb2;
        private TextBox tbResult;
        private Label lbAdition;
        private Label lbLine;
        private Button btCancel;
        private Button btResult;
    }
}