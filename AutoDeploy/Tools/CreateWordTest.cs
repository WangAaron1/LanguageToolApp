

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Table = Xceed.Document.NET.Table;
using VerticalAlignment = Xceed.Document.NET.VerticalAlignment;

namespace newwords
{
    public class CreateWordTest
    {

        private void button1_Click(object sender, EventArgs e)
        {


            List<znode> list23 = new List<znode>();

            OpenFileDialog path = new OpenFileDialog();
            path.ShowDialog();
            if (path.FileName.Length == 0) { MessageBox.Show("文件路径异常！"); return; }

            string[] lines = File.ReadLines(path.FileName, Encoding.UTF8).ToArray();

            for (int i = 0; i < lines.Count(); i++)
            {
                string line = lines[i];
                string[] segs = line.Split('\t'); //注意文件文本的分割方式                                      

                znode data = new znode();

                data.s1 = ss(segs[0]);
                data.s2 = ss(segs[1]);
                data.s3 = ss(segs[2]);
                data.s4 = ss(segs[3]);
                data.s5 = ss(segs[4]);
                data.s6 = ss(segs[5]);
                data.s7 = ss(segs[6]);
                data.s8 = ss(segs[7]);
                data.s9 = ss(segs[8]);

                list23.Add(data);
            }


            MessageBox.Show("加载excel文件数据完成，开始数据接口导入，数据行数： " + list23.Count.ToString());



            foreach (znode one in list23)
            {
                newword(path, one);

            }


        }

        private void newword(OpenFileDialog path, znode one)
        {



            //  string path1 = @"C:\xxx\test.docx";

            string fullname = @"C:\xxx\" + one.s7;

            using (var document = DocX.Create(fullname))
            {
                //文字居中对齐
                document.InsertParagraph().Append("XXXX系统变更、维护申请单").Bold().Alignment = Alignment.center;

                //插入表格
                Table table = document.AddTable(7, 5);


                table.Rows[0].Cells[0].Paragraphs[0].Append("申请人信息").Alignment = Alignment.center; ;
                table.Rows[0].Cells[1].Paragraphs[0].Append("姓名").Alignment = Alignment.center; ;
                table.Rows[0].Cells[2].Paragraphs[0].Append(one.s1).Alignment = Alignment.center;
                table.Rows[0].Cells[3].Paragraphs[0].Append("申请日期").Alignment = Alignment.center;
                table.Rows[0].Cells[4].Paragraphs[0].Append(one.s2);
                table.Rows[0].MinHeight = 20;

                table.Rows[1].Cells[0].Paragraphs[0].Append("需求描述及附件名称").Alignment = Alignment.center;
                table.Rows[1].Cells[0].VerticalAlignment = VerticalAlignment.Center;
                table.Rows[1].MergeCells(1, 4);
                table.Rows[1].Cells[1].Paragraphs[0].Append(one.s8 + "," + one.s9 + "," + string.Format("{0:X}", System.Convert.ToInt32(one.s7, 10)) + "," + one.s3);
                table.Rows[1].Cells[1].VerticalAlignment = VerticalAlignment.Center;
                table.Rows[1].MinHeight = 200;


                table.Rows[2].MergeCells(0, 4);
                table.Rows[2].Cells[0].Paragraphs[0].Append("审批信息").Bold().Alignment = Alignment.center; table.Rows[2].Cells[0].VerticalAlignment = VerticalAlignment.Center;
                table.Rows[2].MinHeight = 20;


                table.Rows[3].Cells[0].Paragraphs[0].Append("变更分类");
                table.Rows[3].MergeCells(1, 4);
                table.Rows[3].Cells[1].Paragraphs[0].Append("□ 数据类   □ 权限类    □ 功能类    □ 开发类    □ 管理类    □ 其他");
                table.Rows[3].MinHeight = 20;

                table.Rows[4].MergeCells(0, 4);
                table.Rows[4].Cells[0].Paragraphs[0].Append("执行信息").Bold().Alignment = Alignment.center; table.Rows[4].Cells[0].VerticalAlignment = VerticalAlignment.Center;
                table.Rows[4].MinHeight = 20;


                table.Rows[5].Cells[0].Paragraphs[0].Append("审批人").Alignment = Alignment.center; table.Rows[5].Cells[0].VerticalAlignment = VerticalAlignment.Center;
                table.Rows[5].MergeCells(1, 2);
                table.Rows[5].Cells[2].Paragraphs[0].Append("执行人").Alignment = Alignment.center; table.Rows[5].Cells[2].VerticalAlignment = VerticalAlignment.Center;
                table.Rows[5].MinHeight = 50;
                table.Rows[5].Cells[3].Paragraphs[0].Append("");
                table.Rows[5].Cells[3].VerticalAlignment = VerticalAlignment.Center;


                table.Rows[6].Cells[0].Paragraphs[0].Append("TR传输编号").Alignment = Alignment.center; table.Rows[6].Cells[0].VerticalAlignment = VerticalAlignment.Center;
                table.Rows[6].MergeCells(1, 2);
                table.Rows[6].Cells[1].Paragraphs[0].Append(one.s5);
                table.Rows[6].Cells[1].VerticalAlignment = VerticalAlignment.Center;

                table.Rows[6].Cells[2].Paragraphs[0].Append("传输日期").Alignment = Alignment.center; table.Rows[6].Cells[2].VerticalAlignment = VerticalAlignment.Center;
                table.Rows[6].MinHeight = 50;
                table.Rows[6].Cells[3].Paragraphs[0].Append("");
                table.Rows[6].Cells[3].VerticalAlignment = VerticalAlignment.Center;


                document.InsertTable(table);
                document.Save();
            }

        }



        public static int ii(object x1)
        {
            return Convert.ToInt32(x1);

        }


        public static string ss(object x1)
        {
            return Convert.ToString(x1);

        }

        public static Decimal dd(object x1)
        {
            return Convert.ToDecimal(x1);

        }

        public static DateTime tt(object x1)
        {

            if (ss(x1).Equals("0000-00-00")) { x1 = null; }
            return Convert.ToDateTime(x1);

        }

        public static TimeSpan t3(object x)
        {

            if (ss(x).Equals("00:00:00")) { x = null; }
            return TimeSpan.Parse(x.ToString());

        }

        public static DateTime t2(object d, object t)
        {

            if (ss(d).Equals("0000-00-00")) { d = null; }
            if (ss(t).Equals("00:00:00")) { t = null; }

            return Convert.ToDateTime(d.ToString() + " " + t.ToString());

        }


    }



    public class znode
    {
        public string s1; //申请人姓名
        public string s2; //申请日期
        public string s3; //需求描述
        public string s4; //完成日期
        public string s5; //TR传输编号
        public string s6; //传输日期
        public string s7; //文件名
        public string s8; //文件名
        public string s9; //文件名

    }



}