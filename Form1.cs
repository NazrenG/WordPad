using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        private FontFamily[] fontFamilies;
        private string[] colors = { "Blue", "Black", "Pink", "Gray", "Green", "Red", "Yellow" };
        private int[] sizes = { 10, 12, 14, 15, 20, 22, 25, 28, 30, 35 };

        public Form1()
        {
            InitializeComponent();
            fontFamilies = new InstalledFontCollection().Families;

            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            foreach (FontFamily fontFamily in fontFamilies)
            {
                comboBox_font.Items.Add(fontFamily.Name);
            }

            foreach (int size in sizes)
            {
                comboBox_size.Items.Add(size);
            }

            foreach (string color in colors)
            {
                comboBox_color.Items.Add(color);
            }
            comboBox_font.Text = "Segoe UI";
            comboBox_size.Text = "9";
            comboBox_color.Text = "Black";
        }

        private void comboBox_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FontName = comboBox_font.SelectedItem as string;
            if (!string.IsNullOrEmpty(FontName))
            {
                richTextBox1.Font = new Font(FontName, richTextBox1.Font.Size);
            }
        }

        private void comboBox_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Size = (int)comboBox_size.SelectedItem;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Size);
        }



        private void comboBox_color_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string ColorName = comboBox_color.SelectedItem as string;
            if (!string.IsNullOrEmpty(ColorName))
            {
                richTextBox1.ForeColor = Color.FromName(ColorName);
            }
        }
        Font currentFont;
        //bold
        private void button_Bold_Click(object sender, EventArgs e)
        {
            currentFont = richTextBox1.Font;
            if (currentFont.Style.HasFlag(FontStyle.Bold))
            {
                richTextBox1.Font = new Font(currentFont, currentFont.Style & ~FontStyle.Bold);
            }
            else
            {
                richTextBox1.Font = new Font(currentFont, currentFont.Style | FontStyle.Bold);
            }
        }
        //underline
        private void button_underline_Click(object sender, EventArgs e)
        {
            currentFont = richTextBox1.Font;
            if (currentFont.Style.HasFlag(FontStyle.Underline))
            {
                richTextBox1.Font = new Font(currentFont, currentFont.Style & ~FontStyle.Underline);
            }
            else
            {
                richTextBox1.Font = new Font(currentFont, currentFont.Style | FontStyle.Underline);
            }
        }
        //italic
        private void button_italic_Click(object sender, EventArgs e)
        {
            currentFont = richTextBox1.Font;
            if (currentFont.Style.HasFlag(FontStyle.Italic))
            {
                richTextBox1.Font = new Font(currentFont, currentFont.Style & ~FontStyle.Italic);
            }
            else
            {
                richTextBox1.Font = new Font(currentFont, currentFont.Style | FontStyle.Italic);
            }
        }
        //alignment
        //left
        private void button_left_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            
        }
        //center
        private void button_center_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        //right
        private void button_right_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName= textBox_load.Text;
            var result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                richTextBox1.Text=File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
           saveFileDialog1.FileName = textBox_save.Text;
            var saveResult = saveFileDialog1.ShowDialog();
            if(saveResult == DialogResult.OK)
            {
                if (!File.Exists(saveFileDialog1.FileName))
                {
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                }
                else
                {
                    var text=File.ReadAllText(saveFileDialog1.FileName);
                    text += $"\n{richTextBox1.Text}";
                    File.WriteAllText(saveFileDialog1.FileName, text);
                }
            }
        }

       
    }
}
