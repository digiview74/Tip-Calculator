namespace Henry_Hernandez_W1_POS409_Tip_Calculator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTipAmt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalAmt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAmt
            // 
            this.txtAmt.BackColor = System.Drawing.Color.White;
            this.txtAmt.Location = new System.Drawing.Point(56, 39);
            this.txtAmt.MaxLength = 6;
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(100, 21);
            this.txtAmt.TabIndex = 0;
            this.txtAmt.TextChanged += new System.EventHandler(this.txtAmt_TextChanged);
            this.txtAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmt_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.BackgroundImage = global::Henry_Hernandez_W1_POS409_Tip_Calculator.Properties.Resources.GroupBox;
            this.groupBox1.Controls.Add(this.labelTipAmt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelTotalAmt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtAmt);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 393);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelTipAmt
            // 
            this.labelTipAmt.BackColor = System.Drawing.Color.White;
            this.labelTipAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTipAmt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelTipAmt.Image = global::Henry_Hernandez_W1_POS409_Tip_Calculator.Properties.Resources.orange_white_gradient;
            this.labelTipAmt.Location = new System.Drawing.Point(56, 279);
            this.labelTipAmt.Name = "labelTipAmt";
            this.labelTipAmt.Size = new System.Drawing.Size(100, 23);
            this.labelTipAmt.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Image = global::Henry_Hernandez_W1_POS409_Tip_Calculator.Properties.Resources.orange_white_gradient;
            this.label5.Location = new System.Drawing.Point(56, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "8.25%";
            // 
            // labelTotalAmt
            // 
            this.labelTotalAmt.BackColor = System.Drawing.Color.White;
            this.labelTotalAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalAmt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelTotalAmt.Image = global::Henry_Hernandez_W1_POS409_Tip_Calculator.Properties.Resources.orange_white_gradient;
            this.labelTotalAmt.Location = new System.Drawing.Point(56, 323);
            this.labelTotalAmt.Name = "labelTotalAmt";
            this.labelTotalAmt.Size = new System.Drawing.Size(100, 23);
            this.labelTotalAmt.TabIndex = 14;
            this.labelTotalAmt.Click += new System.EventHandler(this.labelTotalAmt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(186, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tip Amount";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.Location = new System.Drawing.Point(186, 200);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(56, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(186, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(186, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tax (8.25%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(186, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Amount\r\n(Before Taxes)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radioButton2.Location = new System.Drawing.Point(140, 93);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "20% Tip";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(56, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "15% Tip";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(320, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 21);
            this.button2.TabIndex = 5;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Peru;
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tip Calculator";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Henry_Hernandez_W1_POS409_Tip_Calculator.Properties.Resources.orange_gradient_abstract_1920x1080_wallpaper141006;
            this.ClientSize = new System.Drawing.Size(354, 448);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Tip Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotalAmt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTipAmt;
    }
}

