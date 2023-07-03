namespace _01HelloWorld
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
            lbHellowWorld = new Label();
            btExit = new Button();
            SuspendLayout();
            // 
            // lbHellowWorld
            // 
            lbHellowWorld.AutoSize = true;
            lbHellowWorld.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbHellowWorld.Location = new Point(73, 30);
            lbHellowWorld.Name = "lbHellowWorld";
            lbHellowWorld.Size = new Size(249, 50);
            lbHellowWorld.TabIndex = 0;
            lbHellowWorld.Text = "Hello World !!";
            lbHellowWorld.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btExit
            // 
            btExit.Location = new Point(382, 37);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 36);
            btExit.TabIndex = 1;
            btExit.Text = "Quitter";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 111);
            Controls.Add(btExit);
            Controls.Add(lbHellowWorld);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(500, 150);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Premiers pas en Winform";
            FormClosing += frmMain_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHellowWorld;
        private Button btExit;
    }
}