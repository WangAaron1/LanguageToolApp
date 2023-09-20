using Sunny.UI;
using System.Drawing;
using System.Windows.Forms;

namespace HelperTool
{
    /// <summary>
    /// 为了UI单独封装方法
    /// </summary>
    public static class UIBoxExtension
    {
        public static void AutoFillInputArea(this UITextBox textBox)
        {
            TextBoxAutoFill fill = new TextBoxAutoFill();
            fill.FillText = "请输入...";
            //处理初始化状态
            textBox.Text = fill.FillText;
            textBox.ForeColor = Color.Gray;
            //注册事件
            textBox.GotFocus += fill.GotFocus_CustomText_sunny;
            textBox.LostFocus += fill.LostFocus_CustomText_sunny;
        }
        public static void AutoFillInputArea(this UITextBox textBox, string fillText)
        {
            TextBoxAutoFill fill = new TextBoxAutoFill();
            fill.FillText = fillText;

            //处理初始化状态
            textBox.Text = fillText;
            textBox.ForeColor = Color.Gray;

            //注册事件
            textBox.GotFocus += fill.GotFocus_CustomText_sunny;
            textBox.LostFocus += fill.LostFocus_CustomText_sunny;
        }



        public static void AutoFillInputArea(this TextBox textBox)
        {
            TextBoxAutoFill fill = new TextBoxAutoFill();
            fill.FillText = "请输入...";
            //处理初始化状态
            textBox.Text = fill.FillText;
            textBox.ForeColor = Color.Gray;
            //注册事件
            textBox.GotFocus += fill.GotFocus_CustomText;
            textBox.LostFocus += fill.LostFocus_CustomText;
        }
        public static void AutoFillInputArea(this TextBox textBox, string fillText)
        {
            TextBoxAutoFill fill = new TextBoxAutoFill();
            fill.FillText = fillText;

            //处理初始化状态
            textBox.Text = fillText;
            textBox.ForeColor = Color.Gray;

            //注册事件
            textBox.GotFocus += fill.GotFocus_CustomText;
            textBox.LostFocus += fill.LostFocus_CustomText;
        }
    }
}
