﻿namespace Test
{
    partial class frMain
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
            btColorBlue = new Button();
            btSize = new Button();
            btColorRed = new Button();
            btColorGreen = new Button();
            btColorRand = new Button();
            SuspendLayout();
            // 
            // btColorBlue
            // 
            btColorBlue.Location = new Point(12, 12);
            btColorBlue.Name = "btColorBlue";
            btColorBlue.Size = new Size(229, 23);
            btColorBlue.TabIndex = 0;
            btColorBlue.Text = "Bleu";
            btColorBlue.UseVisualStyleBackColor = true;
            btColorBlue.Click += btTestColor_Click;
            // 
            // btSize
            // 
            btSize.Location = new Point(12, 157);
            btSize.Name = "btSize";
            btSize.Size = new Size(229, 23);
            btSize.TabIndex = 1;
            btSize.Text = "Changement de taille";
            btSize.UseVisualStyleBackColor = true;
            btSize.Click += btSize_Click;
            // 
            // btColorRed
            // 
            btColorRed.Location = new Point(247, 12);
            btColorRed.Name = "btColorRed";
            btColorRed.Size = new Size(229, 23);
            btColorRed.TabIndex = 2;
            btColorRed.Text = "Rouge";
            btColorRed.UseVisualStyleBackColor = true;
            btColorRed.Click += btColorRed_Click;
            // 
            // btColorGreen
            // 
            btColorGreen.Location = new Point(482, 12);
            btColorGreen.Name = "btColorGreen";
            btColorGreen.Size = new Size(229, 23);
            btColorGreen.TabIndex = 3;
            btColorGreen.Text = "Vert";
            btColorGreen.UseVisualStyleBackColor = true;
            btColorGreen.Click += btColorGreen_Click;
            // 
            // btColorRand
            // 
            btColorRand.Location = new Point(247, 87);
            btColorRand.Name = "btColorRand";
            btColorRand.Size = new Size(229, 23);
            btColorRand.TabIndex = 4;
            btColorRand.Text = "Aleatoire";
            btColorRand.UseVisualStyleBackColor = true;
            btColorRand.Click += btColorRand_Click;
            // 
            // frMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 402);
            Controls.Add(btColorRand);
            Controls.Add(btColorGreen);
            Controls.Add(btColorRed);
            Controls.Add(btSize);
            Controls.Add(btColorBlue);
            Name = "frMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fenêtre de test";
            ResumeLayout(false);
        }

        #endregion

        private Button btColorBlue;
        private Button btSize;
        private Button btColorRed;
        private Button btColorGreen;
        private Button btColorRand;
    }
}