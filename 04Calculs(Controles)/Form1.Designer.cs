namespace _04Calculs_Controles_
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tbNb1 = new TextBox();
            tbNb2 = new TextBox();
            tbResult = new TextBox();
            lbAdition = new Label();
            btReset = new Button();
            btResult = new Button();
            SuspendLayout();
            // 
            // tbNb1
            // 
            tbNb1.Location = new Point(313, 28);
            tbNb1.Name = "tbNb1";
            tbNb1.Size = new Size(300, 23);
            tbNb1.TabIndex = 0;
            tbNb1.TextAlign = HorizontalAlignment.Right;
            tbNb1.Enter += tbNb1_Enter;
            // 
            // tbNb2
            // 
            tbNb2.Location = new Point(313, 72);
            tbNb2.Name = "tbNb2";
            tbNb2.Size = new Size(300, 23);
            tbNb2.TabIndex = 1;
            tbNb2.TextAlign = HorizontalAlignment.Right;
            tbNb2.Enter += tbNb2_Enter;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(313, 147);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(300, 23);
            tbResult.TabIndex = 2;
            tbResult.TextAlign = HorizontalAlignment.Right;
            // 
            // lbAdition
            // 
            lbAdition.AutoSize = true;
            lbAdition.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbAdition.Location = new Point(272, 70);
            lbAdition.Name = "lbAdition";
            lbAdition.Size = new Size(25, 25);
            lbAdition.TabIndex = 3;
            lbAdition.Text = "+";
            // 
            // btReset
            // 
            btReset.Location = new Point(650, 27);
            btReset.Name = "btReset";
            btReset.Size = new Size(32, 23);
            btReset.TabIndex = 4;
            btReset.Text = "CE";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // btResult
            // 
            btResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btResult.Location = new Point(261, 147);
            btResult.Name = "btResult";
            btResult.Size = new Size(27, 23);
            btResult.TabIndex = 5;
            btResult.Text = "=";
            btResult.UseVisualStyleBackColor = true;
            btResult.Click += btResult_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 233);
            Controls.Add(btResult);
            Controls.Add(btReset);
            Controls.Add(lbAdition);
            Controls.Add(tbResult);
            Controls.Add(tbNb2);
            Controls.Add(tbNb1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcul";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNb1;
        private TextBox tbNb2;
        private TextBox tbResult;
        private Label lbAdition;
        private Button btReset;
        private Button btResult;
    }
}