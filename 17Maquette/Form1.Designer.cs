namespace _17Maquette
{
    partial class Form1
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
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            tb1 = new TextBox();
            tb2 = new TextBox();
            tb3 = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            tlp1 = new TableLayoutPanel();
            lb1 = new ListBox();
            tlp1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Location = new Point(3, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(44, 30);
            lbl1.TabIndex = 0;
            lbl1.Text = "label1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Location = new Point(3, 30);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(44, 30);
            lbl2.TabIndex = 1;
            lbl2.Text = "label2";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Location = new Point(3, 60);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(44, 30);
            lbl3.TabIndex = 2;
            lbl3.Text = "label3";
            // 
            // tb1
            // 
            tb1.Dock = DockStyle.Fill;
            tb1.Location = new Point(53, 3);
            tb1.Name = "tb1";
            tb1.Size = new Size(93, 23);
            tb1.TabIndex = 3;
            // 
            // tb2
            // 
            tb2.Dock = DockStyle.Fill;
            tb2.Location = new Point(53, 33);
            tb2.Name = "tb2";
            tb2.Size = new Size(93, 23);
            tb2.TabIndex = 4;
            // 
            // tb3
            // 
            tb3.Dock = DockStyle.Fill;
            tb3.Location = new Point(53, 63);
            tb3.Name = "tb3";
            tb3.Size = new Size(93, 23);
            tb3.TabIndex = 5;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Right;
            btn1.Location = new Point(168, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(58, 23);
            btn1.TabIndex = 6;
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.Right;
            btn2.Location = new Point(168, 33);
            btn2.Name = "btn2";
            btn2.Size = new Size(58, 23);
            btn2.TabIndex = 7;
            btn2.Text = "button2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // tlp1
            // 
            tlp1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp1.AutoSize = true;
            tlp1.ColumnCount = 3;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlp1.Controls.Add(lbl1, 0, 0);
            tlp1.Controls.Add(lbl2, 0, 1);
            tlp1.Controls.Add(tb2, 1, 1);
            tlp1.Controls.Add(lbl3, 0, 2);
            tlp1.Controls.Add(btn2, 2, 1);
            tlp1.Controls.Add(btn1, 2, 0);
            tlp1.Controls.Add(tb3, 1, 2);
            tlp1.Controls.Add(lb1, 0, 3);
            tlp1.Controls.Add(tb1, 1, 0);
            tlp1.Location = new Point(0, -1);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 4;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp1.Size = new Size(229, 145);
            tlp1.TabIndex = 9;
            // 
            // lb1
            // 
            lb1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp1.SetColumnSpan(lb1, 3);
            lb1.FormattingEnabled = true;
            lb1.ItemHeight = 15;
            lb1.Location = new Point(3, 93);
            lb1.Name = "lb1";
            lb1.Size = new Size(223, 49);
            lb1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 143);
            Controls.Add(tlp1);
            MinimumSize = new Size(246, 182);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tlp1.ResumeLayout(false);
            tlp1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private TextBox tb1;
        private TextBox tb2;
        private TextBox tb3;
        private Button btn1;
        private Button btn2;
        private TableLayoutPanel tlp1;
        private ListBox lb1;
    }
}