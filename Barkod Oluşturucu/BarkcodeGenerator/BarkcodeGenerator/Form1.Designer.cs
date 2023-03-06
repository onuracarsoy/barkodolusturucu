namespace BarkcodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 0;
            label1.Text = "Kod :";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(323, 15);
            button1.Name = "button1";
            button1.Size = new Size(184, 47);
            button1.TabIndex = 1;
            button1.Text = "Barcode";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(539, 15);
            button2.Name = "button2";
            button2.Size = new Size(184, 47);
            button2.TabIndex = 2;
            button2.Text = "QrCode";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(281, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 266);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BarkcodeGenerator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}