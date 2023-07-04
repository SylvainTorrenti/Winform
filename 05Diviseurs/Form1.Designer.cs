namespace _05Diviseurs
{
    partial class frmDivisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDivisor));
            lbNumerator = new Label();
            lbDeneminator = new Label();
            tbNominator = new TextBox();
            tbDenominator = new TextBox();
            btResult = new Button();
            lbResult = new Label();
            lbNominatorResult = new Label();
            lbDenominatorResult = new Label();
            lbResultN = new Label();
            lbLine = new Label();
            lbResultD = new Label();
            lbLine2 = new Label();
            SuspendLayout();
            // 
            // lbNumerator
            // 
            lbNumerator.AutoSize = true;
            lbNumerator.Location = new Point(34, 20);
            lbNumerator.Name = "lbNumerator";
            lbNumerator.Size = new Size(158, 15);
            lbNumerator.TabIndex = 0;
            lbNumerator.Text = "Veuillez saisir le numérateur :";
            // 
            // lbDeneminator
            // 
            lbDeneminator.AutoSize = true;
            lbDeneminator.Location = new Point(34, 79);
            lbDeneminator.Name = "lbDeneminator";
            lbDeneminator.Size = new Size(171, 15);
            lbDeneminator.TabIndex = 1;
            lbDeneminator.Text = "Veuillez saisir le dénominateur :";
            // 
            // tbNominator
            // 
            tbNominator.Location = new Point(282, 17);
            tbNominator.Name = "tbNominator";
            tbNominator.Size = new Size(166, 23);
            tbNominator.TabIndex = 2;
            // 
            // tbDenominator
            // 
            tbDenominator.Location = new Point(282, 76);
            tbDenominator.Name = "tbDenominator";
            tbDenominator.Size = new Size(166, 23);
            tbDenominator.TabIndex = 3;
            // 
            // btResult
            // 
            btResult.Location = new Point(206, 166);
            btResult.Name = "btResult";
            btResult.Size = new Size(75, 23);
            btResult.TabIndex = 4;
            btResult.Text = "Calculer";
            btResult.UseVisualStyleBackColor = true;
            btResult.Click += btResult_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(34, 212);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(161, 15);
            lbResult.TabIndex = 5;
            lbResult.Text = "Résultat après simplification :";
            // 
            // lbNominatorResult
            // 
            lbNominatorResult.AutoSize = true;
            lbNominatorResult.Location = new Point(34, 254);
            lbNominatorResult.Name = "lbNominatorResult";
            lbNominatorResult.Size = new Size(71, 15);
            lbNominatorResult.TabIndex = 6;
            lbNominatorResult.Text = "Numérateur";
            // 
            // lbDenominatorResult
            // 
            lbDenominatorResult.AutoSize = true;
            lbDenominatorResult.Location = new Point(34, 299);
            lbDenominatorResult.Name = "lbDenominatorResult";
            lbDenominatorResult.Size = new Size(83, 15);
            lbDenominatorResult.TabIndex = 7;
            lbDenominatorResult.Text = "Dénominateur";
            // 
            // lbResultN
            // 
            lbResultN.AutoSize = true;
            lbResultN.Location = new Point(245, 254);
            lbResultN.Name = "lbResultN";
            lbResultN.Size = new Size(0, 15);
            lbResultN.TabIndex = 8;
            // 
            // lbLine
            // 
            lbLine.AutoSize = true;
            lbLine.Location = new Point(206, 269);
            lbLine.Name = "lbLine";
            lbLine.Size = new Size(102, 15);
            lbLine.TabIndex = 9;
            lbLine.Text = "___________________";
            // 
            // lbResultD
            // 
            lbResultD.AutoSize = true;
            lbResultD.Location = new Point(245, 299);
            lbResultD.Name = "lbResultD";
            lbResultD.Size = new Size(0, 15);
            lbResultD.TabIndex = 10;
            // 
            // lbLine2
            // 
            lbLine2.AutoSize = true;
            lbLine2.Location = new Point(280, 46);
            lbLine2.Name = "lbLine2";
            lbLine2.Size = new Size(172, 15);
            lbLine2.TabIndex = 11;
            lbLine2.Text = "_________________________________";
            // 
            // frmDivisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 354);
            Controls.Add(lbLine2);
            Controls.Add(lbResultD);
            Controls.Add(lbLine);
            Controls.Add(lbResultN);
            Controls.Add(lbDenominatorResult);
            Controls.Add(lbNominatorResult);
            Controls.Add(lbResult);
            Controls.Add(btResult);
            Controls.Add(tbDenominator);
            Controls.Add(tbNominator);
            Controls.Add(lbDeneminator);
            Controls.Add(lbNumerator);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDivisor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diviseurs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumerator;
        private Label lbDeneminator;
        private TextBox tbNominator;
        private TextBox tbDenominator;
        private Button btResult;
        private Label lbResult;
        private Label lbNominatorResult;
        private Label lbDenominatorResult;
        private Label lbResultN;
        private Label lbLine;
        private Label lbResultD;
        private Label lbLine2;
    }
}