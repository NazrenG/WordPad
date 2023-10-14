namespace WordPad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox_load = new System.Windows.Forms.TextBox();
            this.textBox_save = new System.Windows.Forms.TextBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.comboBox_font = new System.Windows.Forms.ComboBox();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.button_Bold = new System.Windows.Forms.Button();
            this.button_underline = new System.Windows.Forms.Button();
            this.button_italic = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_center = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(150, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(229, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Font Style";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(363, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alignment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(499, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 111);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(829, 415);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // textBox_load
            // 
            this.textBox_load.Location = new System.Drawing.Point(588, 31);
            this.textBox_load.Name = "textBox_load";
            this.textBox_load.PlaceholderText = "Enter name and load";
            this.textBox_load.Size = new System.Drawing.Size(165, 23);
            this.textBox_load.TabIndex = 6;
   
            // 
            // textBox_save
            // 
            this.textBox_save.Location = new System.Drawing.Point(588, 71);
            this.textBox_save.Name = "textBox_save";
            this.textBox_save.PlaceholderText = "Tap to enter name and save";
            this.textBox_save.Size = new System.Drawing.Size(165, 23);
            this.textBox_save.TabIndex = 7;
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_load.Location = new System.Drawing.Point(759, 27);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 8;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_save.Location = new System.Drawing.Point(759, 70);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox_size
            // 
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Location = new System.Drawing.Point(150, 54);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(35, 23);
            this.comboBox_size.TabIndex = 10;
            this.comboBox_size.SelectedIndexChanged += new System.EventHandler(this.comboBox_size_SelectedIndexChanged);
            // 
            // comboBox_font
            // 
            this.comboBox_font.DisplayMember = "hkk";
            this.comboBox_font.FormattingEnabled = true;
            this.comboBox_font.Location = new System.Drawing.Point(5, 54);
            this.comboBox_font.Name = "comboBox_font";
            this.comboBox_font.Size = new System.Drawing.Size(121, 23);
            this.comboBox_font.TabIndex = 11;
            this.comboBox_font.Tag = "";
            this.comboBox_font.SelectedIndexChanged += new System.EventHandler(this.comboBox_font_SelectedIndexChanged);
            // 
            // comboBox_color
            // 
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Location = new System.Drawing.Point(481, 54);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(91, 23);
            this.comboBox_color.TabIndex = 11;
            this.comboBox_color.SelectedIndexChanged += new System.EventHandler(this.comboBox_color_SelectedIndexChanged_1);
            // 
            // button_Bold
            // 
            this.button_Bold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_Bold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_Bold.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Bold.Location = new System.Drawing.Point(209, 51);
            this.button_Bold.Name = "button_Bold";
            this.button_Bold.Size = new System.Drawing.Size(34, 26);
            this.button_Bold.TabIndex = 12;
            this.button_Bold.Text = "B";
            this.button_Bold.UseVisualStyleBackColor = true;
            this.button_Bold.Click += new System.EventHandler(this.button_Bold_Click);
            // 
            // button_underline
            // 
            this.button_underline.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button_underline.Location = new System.Drawing.Point(249, 51);
            this.button_underline.Name = "button_underline";
            this.button_underline.Size = new System.Drawing.Size(34, 26);
            this.button_underline.TabIndex = 12;
            this.button_underline.Text = "U";
            this.button_underline.UseVisualStyleBackColor = true;
            this.button_underline.Click += new System.EventHandler(this.button_underline_Click);
            // 
            // button_italic
            // 
            this.button_italic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button_italic.Location = new System.Drawing.Point(289, 51);
            this.button_italic.Name = "button_italic";
            this.button_italic.Size = new System.Drawing.Size(34, 26);
            this.button_italic.TabIndex = 12;
            this.button_italic.Text = "I";
            this.button_italic.UseVisualStyleBackColor = true;
            this.button_italic.Click += new System.EventHandler(this.button_italic_Click);
            // 
            // button_left
            // 
            this.button_left.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_left.Location = new System.Drawing.Point(347, 51);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(34, 26);
            this.button_left.TabIndex = 12;
            this.button_left.Text = "L";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_center
            // 
            this.button_center.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_center.Location = new System.Drawing.Point(387, 51);
            this.button_center.Name = "button_center";
            this.button_center.Size = new System.Drawing.Size(34, 26);
            this.button_center.TabIndex = 12;
            this.button_center.Text = "C";
            this.button_center.UseVisualStyleBackColor = true;
            this.button_center.Click += new System.EventHandler(this.button_center_Click);
            // 
            // button_right
            // 
            this.button_right.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_right.Location = new System.Drawing.Point(427, 51);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(34, 26);
            this.button_right.TabIndex = 12;
            this.button_right.Text = "R";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 524);
            this.Controls.Add(this.button_center);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_italic);
            this.Controls.Add(this.button_underline);
            this.Controls.Add(this.button_Bold);
            this.Controls.Add(this.comboBox_color);
            this.Controls.Add(this.comboBox_font);
            this.Controls.Add(this.comboBox_size);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.textBox_save);
            this.Controls.Add(this.textBox_load);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WordPad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBox1;
        private TextBox textBox_load;
        private TextBox textBox_save;
        private Button button_load;
        private Button button_save;
        private ComboBox comboBox_size;
        private ComboBox comboBox_font;
        private ComboBox comboBox_color;
        private Button button_Bold;
        private Button button_underline;
        private Button button_italic;
        private Button button_left;
        private Button button_center;
        private Button button_right;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}