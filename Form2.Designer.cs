﻿namespace lab2_wizualne
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 47);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Procesor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 47);
            label2.Name = "label2";
            label2.Size = new Size(25, 25);
            label2.TabIndex = 2;
            label2.Text = "zł";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "procesor1", "procesor2", "procesor3" });
            comboBox1.Location = new Point(39, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 158);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 4;
            label3.Text = "Dysk:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(94, 31);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 161);
            label4.Name = "label4";
            label4.Size = new Size(25, 25);
            label4.TabIndex = 6;
            label4.Text = "zł";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 321);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 10;
            label5.Text = "Reszta:         1000zł";
            // 
            // button1
            // 
            button1.Location = new Point(29, 399);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(178, 399);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(39, 192);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(127, 29);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "240GB SSD";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(39, 227);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(135, 29);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "500GB SATA";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(39, 262);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(145, 29);
            radioButton3.TabIndex = 15;
            radioButton3.TabStop = true;
            radioButton3.Text = "1000GB SATA";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 445);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Komputer";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}