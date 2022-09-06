using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        bool is計算稅金 = true;
        int int折扣活動代碼 = 0;
        int int總價 = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl訂購資料.Text = GlobalVar.訂購人資訊;
            foreach (Class1 訂購品項資訊 in GlobalVar.list訂購品項列表)
            {                
                string 訂購品項 = 訂購品項資訊.訂購品項;
                int 單價 = 訂購品項資訊.單價;
                int 品項杯數 = 訂購品項資訊.品項杯數;
                int 品項總價 = 訂購品項資訊.品項總價;
                string 甜度 = 訂購品項資訊.甜度;
                string 冰塊 = 訂購品項資訊.冰塊;
                string 加料 = 訂購品項資訊.加料;
                int 加料價格 =訂購品項資訊.加料價格;

                string str單品資訊 = string.Format("{0} 單價:{1} 總共{2}杯 配料:{3} {4} {5} 總價:{6}元", 訂購品項, 單價, 品項杯數, 加料, 甜度, 冰塊, 品項總價);

                lBx訂購品項列表.Items.Add(str單品資訊);
            }
            計算訂單總價();
        }

        private void lBx訂購品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            lBx訂購品項列表.Items.Clear();
            GlobalVar.list訂購品項列表.Clear();
            計算訂單總價();
        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (lBx訂購品項列表.SelectedIndex >=0)
            {
                int selIndex = lBx訂購品項列表.SelectedIndex;
                lBx訂購品項列表.Items.RemoveAt(selIndex);
                GlobalVar.list訂購品項列表.RemoveAt(selIndex);
                計算訂單總價();
            }
            else 
            {
                MessageBox.Show("請選擇品項");
            }
        }
        void 計算訂單總價()
        {
            int 總金額 = 0;
            int 稅金 = 0;
            foreach (Class1 訂購品項資訊 in GlobalVar.list訂購品項列表)
            {
                總金額 += 訂購品項資訊.品項總價;

            }
            
            if (is計算稅金 == true)
            {
                稅金 +=Convert.ToInt32(總金額 * 1.05);
            }
            else
            {
                稅金 = 總金額;
            }
            lbl訂單總價格.Text = "此訂單總金額" + 稅金 + "元";
        }

        private void chk稅金_CheckedChanged(object sender, EventArgs e)
        {
            if (chk稅金.Checked == true)
            {
                is計算稅金 = true;
                計算訂單總價();
            } else
            {
                is計算稅金 = false;
                計算訂單總價();
            }            
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        { 
            int折扣活動代碼 = 101;
            計算訂單總價();
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        { 
            int折扣活動代碼 = 102;
            計算訂單總價();
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        { 
            int折扣活動代碼 = 103;
            計算訂單總價();
        }

        private void btn離開_Click(object sender, EventArgs e)
        {
            GlobalVar.form菜單.Show();
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.form菜單.Show();
        }

        private void btn儲存訂單_Click(object sender, EventArgs e)
        {/*
            string str檔案路徑 = @"C:\Users\iii\Desktop\課程\NET";
            System.Random myRnd = new Random();
            int myNum = myRnd.Next(1000, 9999);
            string str檔名 = DateTime.Now.ToString("D") + myNum + @"訂購檔.txt";
            string str完整檔案路徑 = str檔案路徑 + @"\" + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Text File|*.txt";

            DialogResult R = sfd.ShowDialog(); //獨佔模式

            if (R == DialogResult.OK)
            {
                str完整檔案路徑 = sfd.FileName;
            } else
            {
                return;
            }
            //訂單內容存檔
            List<string> list訂單資訊 = new List<string>();
            list訂單資訊.Add("********冷飲店訂購單********");
            list訂單資訊.Add("----------------------------");
            list訂單資訊.Add("訂購時間:"+DateTime.Now.ToString()+"訂購人:"+GlobalVar.訂購人資訊);
            list訂單資訊.Add("----------------------------");
            list訂單資訊.Add("訂購品項");

            foreach (ArrayList 訂購品項資訊 in GlobalVar.list訂購品項列表)
            {
                string 訂購品項 = Convert.ToString(訂購品項資訊[0]);
                int 單價 = (int)訂購品項資訊[1];
                int 品項杯數 = (int)訂購品項資訊[2];
                int 品項總價 = (int)訂購品項資訊[3];
                string 甜度 = (string)訂購品項資訊[4];
                string 冰塊 = (string)訂購品項資訊[5];
                string 加料 = (string)訂購品項資訊[6];
                int 加料價格 = (int)訂購品項資訊[7];

                string str單品資訊 = string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", 訂購品項, 單價, 品項杯數, 品項總價, 甜度, 冰塊, 加料, 加料價格);

                list訂單資訊.Add(str單品資訊);
            }
                list訂單資訊.Add("----------------------------");
                list訂單資訊.Add("總價" + int總價);
                list訂單資訊.Add("----------------------------");
                list訂單資訊.Add("************結束************");

            System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8);
            MessageBox.Show("存檔成功");
            */
        }
    }
}
