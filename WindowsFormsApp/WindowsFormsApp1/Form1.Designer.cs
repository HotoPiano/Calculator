namespace WindowsFormsApp1
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bequals = new System.Windows.Forms.Button();
            this.bplus = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.bdivide = new System.Windows.Forms.Button();
            this.bminus = new System.Windows.Forms.Button();
            this.bmultiply = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBox1.Location = new System.Drawing.Point(5, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(240, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.bequals, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.bplus, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bdot, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.b0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.b9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.b8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.b6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.b5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.b4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bdivide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.bminus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.bmultiply, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.b1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.b2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 88);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(200, 200);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 220);
            this.tableLayoutPanel1.TabIndex = 17;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // bequals
            // 
            this.bequals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bequals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bequals.Location = new System.Drawing.Point(180, 165);
            this.bequals.Margin = new System.Windows.Forms.Padding(0);
            this.bequals.Name = "bequals";
            this.bequals.Size = new System.Drawing.Size(60, 55);
            this.bequals.TabIndex = 13;
            this.bequals.Text = "=";
            this.bequals.UseVisualStyleBackColor = true;
            this.bequals.Click += new System.EventHandler(this.bequals_Click);
            // 
            // bplus
            // 
            this.bplus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bplus.Location = new System.Drawing.Point(120, 165);
            this.bplus.Margin = new System.Windows.Forms.Padding(0);
            this.bplus.Name = "bplus";
            this.bplus.Size = new System.Drawing.Size(60, 55);
            this.bplus.TabIndex = 12;
            this.bplus.Text = "+";
            this.bplus.UseVisualStyleBackColor = true;
            this.bplus.Click += new System.EventHandler(this.bplus_Click);
            // 
            // bdot
            // 
            this.bdot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bdot.Location = new System.Drawing.Point(60, 165);
            this.bdot.Margin = new System.Windows.Forms.Padding(0);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(60, 55);
            this.bdot.TabIndex = 11;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = true;
            this.bdot.Click += new System.EventHandler(this.bdot_Click);
            // 
            // b0
            // 
            this.b0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b0.Location = new System.Drawing.Point(0, 165);
            this.b0.Margin = new System.Windows.Forms.Padding(0);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(60, 55);
            this.b0.TabIndex = 10;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b9
            // 
            this.b9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b9.Location = new System.Drawing.Point(120, 110);
            this.b9.Margin = new System.Windows.Forms.Padding(0);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(60, 55);
            this.b9.TabIndex = 9;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b8.Location = new System.Drawing.Point(60, 110);
            this.b8.Margin = new System.Windows.Forms.Padding(0);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(60, 55);
            this.b8.TabIndex = 8;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b7.Location = new System.Drawing.Point(0, 110);
            this.b7.Margin = new System.Windows.Forms.Padding(0);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(60, 55);
            this.b7.TabIndex = 7;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b6.Location = new System.Drawing.Point(120, 55);
            this.b6.Margin = new System.Windows.Forms.Padding(0);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(60, 55);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b5.Location = new System.Drawing.Point(60, 55);
            this.b5.Margin = new System.Windows.Forms.Padding(0);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(60, 55);
            this.b5.TabIndex = 5;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b4.Location = new System.Drawing.Point(0, 55);
            this.b4.Margin = new System.Windows.Forms.Padding(0);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(60, 55);
            this.b4.TabIndex = 4;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // bdivide
            // 
            this.bdivide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bdivide.Location = new System.Drawing.Point(180, 0);
            this.bdivide.Margin = new System.Windows.Forms.Padding(0);
            this.bdivide.Name = "bdivide";
            this.bdivide.Size = new System.Drawing.Size(60, 55);
            this.bdivide.TabIndex = 14;
            this.bdivide.Text = "/";
            this.bdivide.UseVisualStyleBackColor = true;
            this.bdivide.Click += new System.EventHandler(this.bdivide_Click);
            // 
            // bminus
            // 
            this.bminus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bminus.Location = new System.Drawing.Point(180, 55);
            this.bminus.Margin = new System.Windows.Forms.Padding(0);
            this.bminus.Name = "bminus";
            this.bminus.Size = new System.Drawing.Size(60, 55);
            this.bminus.TabIndex = 16;
            this.bminus.Text = "-";
            this.bminus.UseVisualStyleBackColor = true;
            this.bminus.Click += new System.EventHandler(this.bminus_Click);
            // 
            // bmultiply
            // 
            this.bmultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bmultiply.Location = new System.Drawing.Point(180, 110);
            this.bmultiply.Margin = new System.Windows.Forms.Padding(0);
            this.bmultiply.Name = "bmultiply";
            this.bmultiply.Size = new System.Drawing.Size(60, 55);
            this.bmultiply.TabIndex = 15;
            this.bmultiply.Text = "x";
            this.bmultiply.UseVisualStyleBackColor = true;
            this.bmultiply.Click += new System.EventHandler(this.bmultiply_Click);
            // 
            // b1
            // 
            this.b1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b1.Location = new System.Drawing.Point(0, 0);
            this.b1.Margin = new System.Windows.Forms.Padding(0);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(60, 55);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b3
            // 
            this.b3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b3.Location = new System.Drawing.Point(60, 0);
            this.b3.Margin = new System.Windows.Forms.Padding(0);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(60, 55);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b2.Location = new System.Drawing.Point(120, 0);
            this.b2.Margin = new System.Windows.Forms.Padding(0);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(60, 55);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(265, 350);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.sChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_keyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bequals;
        private System.Windows.Forms.Button bplus;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bminus;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button bmultiply;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button bdivide;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
    }
}

