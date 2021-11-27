using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace baitapnet01
{
    public partial class Form1 : Form
    {
        private string pass = "2001";
        public Form1()
        {
            InitializeComponent();
            RunRead();
        }
        private void RunRead()
        {
            FileInfo theSourceFile = new FileInfo(@"D:\Documents\.net\baitapnet01\102190053.txt");

            StreamReader reader = theSourceFile.OpenText();

            string text = reader.ReadLine();

            while (text != null)
            {
                listBox1.Items.Add(text);
                text = reader.ReadLine();


            }

            reader.Close();

        }

        private void w()
        {
            FileInfo theSourceFile = new FileInfo(@"D:\Documents\.net\baitapnet01\102190053.txt");
            StreamWriter writer = new StreamWriter(@"D:\Documents\.net\baitapnet01\102190053.txt", false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                writer.WriteLine((string)listBox1.Items[i]);
            }
            writer.Close();

        }

        private void but_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.TextLength < 4)
            {
                textBox1.Text = textBox1.Text + btn.Text;

            }



        }

        private void btc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btok_Click(object sender, EventArgs e)
        {
            bt_hehe();
        }
        private void bt_hehe()
        {
            DateTime d = DateTime.Now;
            if (textBox1.Text == "2001")
            {
                listBox1.Items.Add(d.ToString() + "  Access granted");
            }

            else if (textBox1.TextLength == 1)
            {
                listBox1.Items.Add(d.ToString() + "   Restricted Access ");
            }
            else
            {
                listBox1.Items.Add(d.ToString() + "  Access denied");
            }

            w();

        }


        private void battap01_net_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;


            }

            if (e.KeyChar == 13)
            {

                bt_hehe();

            }
            if (e.KeyChar == 8)
            {
                textBox1.Text = "";
            }


        }


    }
}
