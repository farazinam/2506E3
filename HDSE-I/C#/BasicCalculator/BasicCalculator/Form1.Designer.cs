namespace BasicCalculator
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
            label1 = new Label();
            label2 = new Label();
            inp1 = new TextBox();
            label3 = new Label();
            inp2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Clear = new Button();
            richTextBox1 = new RichTextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 48);
            label1.Name = "label1";
            label1.Size = new Size(151, 27);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 107);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Operand 1";
            // 
            // inp1
            // 
            inp1.Location = new Point(294, 104);
            inp1.Name = "inp1";
            inp1.Size = new Size(235, 23);
            inp1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 165);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 3;
            label3.Text = "Operand 2";
            // 
            // inp2
            // 
            inp2.Location = new Point(294, 165);
            inp2.Name = "inp2";
            inp2.Size = new Size(235, 23);
            inp2.TabIndex = 4;
            inp2.TextChanged += inp2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(135, 275);
            button1.Name = "button1";
            button1.Size = new Size(53, 43);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 231);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Result:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(380, 231);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // button2
            // 
            button2.Location = new Point(240, 275);
            button2.Name = "button2";
            button2.Size = new Size(53, 43);
            button2.TabIndex = 8;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(345, 275);
            button3.Name = "button3";
            button3.Size = new Size(53, 43);
            button3.TabIndex = 9;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(451, 275);
            button4.Name = "button4";
            button4.Size = new Size(53, 43);
            button4.TabIndex = 10;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Clear
            // 
            Clear.BackColor = SystemColors.Info;
            Clear.Location = new Point(159, 355);
            Clear.Name = "Clear";
            Clear.Size = new Size(113, 31);
            Clear.TabIndex = 11;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += button5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(582, 206);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(164, 192);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(391, 355);
            button5.Name = "button5";
            button5.Size = new Size(113, 31);
            button5.TabIndex = 13;
            button5.Text = "History";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 470);
            Controls.Add(button5);
            Controls.Add(richTextBox1);
            Controls.Add(Clear);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(inp2);
            Controls.Add(label3);
            Controls.Add(inp1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox inp1;
        private Label label3;
        private TextBox inp2;
        private Button button1;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button Clear;
        private RichTextBox richTextBox1;
        private Button button5;
    }
}
