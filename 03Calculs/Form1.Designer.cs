namespace _03Calculs
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
            lbAdition = new Label();
            tbResult = new TextBox();
            btEgal = new Button();
            btReset = new Button();
            SuspendLayout();
            // 
            // tbNb1
            // 
            tbNb1.Location = new Point(277, 24);
            tbNb1.Name = "tbNb1";
            tbNb1.Size = new Size(502, 23);
            tbNb1.TabIndex = 0;
            tbNb1.TextAlign = HorizontalAlignment.Right;
            // 
            // tbNb2
            // 
            tbNb2.Location = new Point(277, 78);
            tbNb2.Name = "tbNb2";
            tbNb2.Size = new Size(502, 23);
            tbNb2.TabIndex = 1;
            tbNb2.TextAlign = HorizontalAlignment.Right;
            // 
            // lbAdition
            // 
            lbAdition.AutoSize = true;
            lbAdition.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbAdition.Location = new Point(236, 76);
            lbAdition.Name = "lbAdition";
            lbAdition.Size = new Size(25, 25);
            lbAdition.TabIndex = 2;
            lbAdition.Text = "+";
            // 
            // tbResult
            // 
            tbResult.Location = new Point(277, 134);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(502, 23);
            tbResult.TabIndex = 3;
            tbResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btEgal
            // 
            btEgal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btEgal.Location = new Point(236, 134);
            btEgal.Name = "btEgal";
            btEgal.Size = new Size(33, 23);
            btEgal.TabIndex = 4;
            btEgal.Text = "=";
            btEgal.UseVisualStyleBackColor = true;
            btEgal.Click += btEgal_Click;
            // 
            // btReset
            // 
            btReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btReset.Location = new Point(796, 24);
            btReset.Name = "btReset";
            btReset.Size = new Size(36, 23);
            btReset.TabIndex = 5;
            btReset.Text = "CE";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 200);
            Controls.Add(btReset);
            Controls.Add(btEgal);
            Controls.Add(tbResult);
            Controls.Add(lbAdition);
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
        private Label lbAdition;
        private TextBox tbResult;
        private Button btEgal;
        private Button btReset;
    }
}