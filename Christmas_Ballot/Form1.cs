using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Christmas_Ballot
{
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer tt = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tt2 = new System.Windows.Forms.Timer();
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer();

        Random rnd = new Random();
        int timersleep = 0;
        int ans = -1;
        int oldran = -1;
        int newran = -1;

        Boolean Hackers = false;

        public Form1()
        {
            InitializeComponent();
            butt_run.Click += new EventHandler(butt_run_Click);
            butt_rebuild.Click += new EventHandler(butt_rebuild_Click);
            textstart.KeyPress += new KeyPressEventHandler(no_KeyPress);
            textend.KeyPress += new KeyPressEventHandler(no_KeyPress);
            butt_toleft.Click += new EventHandler(butt_toleft_Click);
            butt_toright.Click += new EventHandler(butt_toright_Click);
            this.Resize += new EventHandler(Form1_Resize);
            textBox1.AutoSize = false;
            textBox1.Height = 578;
            textBox1.Font = new Font(textBox1.Font.FontFamily, 578 * 3 / 4);

            textstart.MaxLength = 3;
            textend.MaxLength = 3;

            textstart.Text = "1";
            
            tt.Tick += new EventHandler(tt_Tick);


            tt2.Tick += new EventHandler(tt2_Tick);

            sp.SoundLocation = @"C:\Windows\Media\Speech On.wav";
            //this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }
        /*
        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = (System.Windows.Forms.Cursor.Position.X - this.Location.X).ToString()  ;
        }
        */

        void tt_Tick(object sender, EventArgs e)
        {
            buttallopen();
            tt.Stop();
        }




        //數字拉到右邊
        void butt_toright_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox2.SelectedItem = listBox1.SelectedItem;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
        }

        //數字拉到左邊
        void butt_toleft_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox1.SelectedItem = listBox2.SelectedItem;
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        //只能打數字
        void no_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.KeyChar == (Char)48 ~ 57 -----> 0~9
            // e.KeyChar == (Char)8 -----------> Backpace
            // e.KeyChar == (Char)13-----------> Enter
            if (e.KeyChar == (Char)48 || e.KeyChar == (Char)49 ||
               e.KeyChar == (Char)50 || e.KeyChar == (Char)51 ||
               e.KeyChar == (Char)52 || e.KeyChar == (Char)53 ||
               e.KeyChar == (Char)54 || e.KeyChar == (Char)55 ||
               e.KeyChar == (Char)56 || e.KeyChar == (Char)57 ||
               e.KeyChar == (Char)13 || e.KeyChar == (Char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        //重建抽籤區
        void butt_rebuild_Click(object sender, EventArgs e)
        {



            int istart = 1;
            int iend = 1;
            try
            {
                istart = int.Parse(textstart.Text);
                iend = int.Parse(textend.Text);
            }
            catch
            {
                MessageBox.Show("輸入不正確");
                return;
            }

            if (MessageBox.Show("確定重建抽籤區嗎？\n確認後當前狀態將遺失", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            textBox1.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            if (istart < iend)
                for (int i = istart; i <= iend; i++)
                {
                    listBox1.Items.Add(i);
                }
            else
                for (int i = istart; i >= iend; i--)
                {
                    listBox1.Items.Add(i);
                }
        }




        //抽籤的特效
        void tt2_Tick(object sender, EventArgs e)
        {
            if (timersleep < 500)
                timersleep = (int)(timersleep * 1.1);
            else
                timersleep = (int)(timersleep * 1.5);
            
            tt2.Interval = timersleep;

            if (timersleep > 1000)
            {
                tt2.Stop();

                if (Hackers)
                {
                    if (listBox1.Items.Count > 36)
                        ans = rnd.Next(0, 36);
                    else
                        ans = rnd.Next(0, listBox1.Items.Count);
                    ans = rnd.Next(0, 0);  //測試
                }
                else
                    ans = rnd.Next(0, listBox1.Items.Count);

                textBox1.Text = listBox1.Items[ans].ToString();

                listBox2.Items.Add(listBox1.Items[ans]);
                listBox2.SelectedItem = listBox1.Items[ans];
                listBox1.Items.RemoveAt(ans);
                try
                {
                    if (!checkBox2.Checked) sp.Play();
                }
                catch { }

                textBox1.ForeColor = System.Drawing.Color.Black;

                return;

            }






            while (true)
            {
                newran = rnd.Next(0, listBox1.Items.Count);
                if (oldran == newran && listBox1.Items.Count != 1)
                {
                    continue;
                }
                oldran = newran;

                textBox1.Text = listBox1.Items[oldran].ToString();
                textBox1.Refresh();
                try
                {
                    if (!checkBox2.Checked) sp.Play();
                }
                catch { }

                break;
            }




        }

        //抽籤
        void butt_run_Click(object sender, EventArgs e)
        {




            if ((System.Windows.Forms.Cursor.Position.X - this.Location.X) > 226)
                Hackers = true;
            else
                Hackers = false;

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("已經抽完了！！");
                return;
            }


            buttallclose();



            this.textBox1.ForeColor = System.Drawing.Color.Silver;

            if (!checkBox1.Checked)
            {
                tt.Interval = 8000;
                tt.Start();

                tt2.Interval = timersleep = 20;
                tt2.Start();
                tt2_Tick(sender, e);
            }
            else
            {
                tt.Interval = 1000;
                tt.Start();

                timersleep = 999999;
                tt2_Tick(sender, e);
            }

            /*
            int oldran = 0;
            int newran = 0;
            for (int i = 100; i <= 500; i += 100)
            {
                for (int j = 0; j < (5 - (i / 100)) * 2; j++)
                {

                    newran = rnd.Next(0, listBox1.Items.Count);
                    if (oldran == newran )
                    {
                        j--;
                        continue;
                    }
                    oldran = newran;

                    textBox1.Text = listBox1.Items[newran].ToString();
                    textBox1.Refresh();
                    try
                    {
                        sp.Play();
                    }
                    catch { }
                    Thread.Sleep(i);
                }
            }
            */

            /*
                int ans = rnd.Next(0, listBox1.Items.Count);

                textBox1.Text = listBox1.Items[ans].ToString();

                listBox2.Items.Add(listBox1.Items[ans]);
                listBox2.SelectedItem = listBox1.Items[ans];
                listBox1.Items.RemoveAt(ans);
                try
                {
                    sp.Play();
                }
                catch { }
             */


            
        }


        //按鈕全中止
        void buttallopen()
        {
            butt_run.Enabled = true;
            butt_rebuild.Enabled = true;
            butt_toleft.Enabled = true;
            butt_toright.Enabled = true;
        }


        //按鈕全開啟
        void buttallclose()
        {
            butt_run.Enabled = false;
            butt_rebuild.Enabled = false;
            butt_toleft.Enabled = false;
            butt_toright.Enabled = false;
        }

        //大小控制
        void Form1_Resize(object sender, EventArgs e)
        {
            //高
            groupBox1.Location = new Point(groupBox1.Location.X, this.Height - 162);
            listBox1.Size = new Size(listBox1.Size.Width, this.Height - 192);
            listBox2.Size = new Size(listBox2.Size.Width, this.Height - 192);
            textBox1.Height = this.Height - 62;
            textBox1.Font = new Font(textBox1.Font.FontFamily, (this.Height - 62) * 3 / 4);

            //寬
            textBox1.Width = this.Width - 335;


        }


    }
}
