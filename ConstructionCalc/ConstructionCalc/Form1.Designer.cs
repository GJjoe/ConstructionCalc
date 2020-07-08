namespace ConstructionCalc
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
            this.button1 = new System.Windows.Forms.Button();
            this.lenBox = new System.Windows.Forms.TextBox();
            this.widBox = new System.Windows.Forms.TextBox();
            this.depBox = new System.Windows.Forms.TextBox();
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.matBox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lenBox
            // 
            this.lenBox.Location = new System.Drawing.Point(59, 109);
            this.lenBox.Name = "lenBox";
            this.lenBox.Size = new System.Drawing.Size(100, 20);
            this.lenBox.TabIndex = 2;
            // 
            // widBox
            // 
            this.widBox.Location = new System.Drawing.Point(208, 109);
            this.widBox.Name = "widBox";
            this.widBox.Size = new System.Drawing.Size(100, 20);
            this.widBox.TabIndex = 3;
            // 
            // depBox
            // 
            this.depBox.Location = new System.Drawing.Point(358, 109);
            this.depBox.Name = "depBox";
            this.depBox.Size = new System.Drawing.Size(100, 20);
            this.depBox.TabIndex = 4;
            // 
            // unitBox
            // 
            this.unitBox.FormattingEnabled = true;
            this.unitBox.Items.AddRange(new object[] {
            "inches",
            "feet"});
            this.unitBox.Location = new System.Drawing.Point(358, 140);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(100, 21);
            this.unitBox.TabIndex = 5;
            // 
            // matBox
            // 
            this.matBox.FormattingEnabled = true;
            this.matBox.Items.AddRange(new object[] {
            "Class A",
            "Class B",
            "Crushed Stone",
            "4\" Rock",
            "Asphalt Millings"});
            this.matBox.Location = new System.Drawing.Point(16, 25);
            this.matBox.Name = "matBox";
            this.matBox.Size = new System.Drawing.Size(121, 21);
            this.matBox.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(481, 226);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Units";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(363, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 13;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(509, 40);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(429, 359);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(422, 405);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Truck Compacity";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(863, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Document";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Calculation";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(364, 43);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown2.TabIndex = 20;
            this.numericUpDown2.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Over estimate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "percent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 438);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.matBox);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.depBox);
            this.Controls.Add(this.widBox);
            this.Controls.Add(this.lenBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lenBox;
        private System.Windows.Forms.TextBox widBox;
        private System.Windows.Forms.TextBox depBox;
        private System.Windows.Forms.ComboBox unitBox;
        private System.Windows.Forms.ComboBox matBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

