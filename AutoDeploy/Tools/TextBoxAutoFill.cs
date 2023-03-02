using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HelperTool
{
    public class TextBoxAutoFill
    {
        public string FillText { get; set; }

        public void GotFocus_CustomText(object sender, EventArgs e)
        {
            if (sender == null || FillText == null) return;
            TextBox textBox = (TextBox)sender;

            textBox.ForeColor = Color.Black;
            if (textBox.Text.Contains(FillText))
                textBox.Text = "";
        }
        public void LostFocus_CustomText(object sender, EventArgs e)
        {
            if (sender == null) return;
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = FillText;
            }
        }

        public void GotFocus_CustomText_sunny(object sender, EventArgs e)
        {
            if (sender == null || FillText == null) return;
            UITextBox textBox = (UITextBox)sender;

            textBox.ForeColor = Color.Black;
            if (textBox.Text.Contains(FillText))
                textBox.Text = "";
        }
        public void LostFocus_CustomText_sunny(object sender, EventArgs e)
        {
            if (sender == null) return;
            UITextBox textBox = (UITextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = FillText;
            }
        }
    }
}
