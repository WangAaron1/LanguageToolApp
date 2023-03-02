
using Sunny.UI;
using System;

public static class StringExtension
{

    public static string LineProcessor(this string text)
    {
        text.TrimStart('\n');
        if (text.Contains("\n"))
        {
            //������ת��
            text = text.Replace("\n", "\\n");
        }
        if (text.Contains(@"\n\n"))
        {
            text = text.Replace(@"\n\n", "\\n");
        }
        if (text.Contains("\r"))
        {
            text = text.Replace("\r", "");
        }
        return text;
    }

    /// <summary>
    /// ͨ�õ�TextBox���������õĻص�
    /// </summary>
    /// <returns></returns>
    public static void SetLineMark(object value, EventArgs eventArgs)
    {
        UITextBox box = (UITextBox)value;
        if (box.Text.IsNullOrEmpty())
        {
            return;
        }
        var text = box.Text;
        text = text.LineProcessor();
        box.Text = text;
    }

}