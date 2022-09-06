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
    public partial class Form1 : Form
    {
        List<string> list品項名稱 = new List<string>(); //key
        List<int> list品項價格 = new List<int>(); //value
        List<string> list甜度 = new List<string>();
        List<string> list冰塊 = new List<string>();
        List<string> list加料 = new List<string>();
        List<int> list加料價格 = new List<int>();
        
        Class1 共用 = new Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //key
            list品項名稱.Add("高山金萱");
            list品項名稱.Add("翡翠綠茶");
            list品項名稱.Add("錫蘭紅茶");
            list品項名稱.Add("文山清茶");
            list品項名稱.Add("古早味紅茶");
            list品項名稱.Add("紅茶拿鐵");
            list品項名稱.Add("鐵觀音拿鐵");
            list品項名稱.Add("阿華田拿鐵");
            list品項名稱.Add("錫蘭奶茶");
            list品項名稱.Add("百香綠茶");
            list品項名稱.Add("百香多多");
            list品項名稱.Add("梅子綠茶");
            list品項名稱.Add("冬瓜茶");
            lBx冷飲品項.Update();
            //value
            list品項價格.Add(25);
            list品項價格.Add(25);
            list品項價格.Add(25);
            list品項價格.Add(25);
            list品項價格.Add(25);
            list品項價格.Add(55);
            list品項價格.Add(55);
            list品項價格.Add(65);
            list品項價格.Add(45);
            list品項價格.Add(50);
            list品項價格.Add(60);
            list品項價格.Add(35);
            list品項價格.Add(25);
            lBx冷飲品項.Update();
            //至少要有12冷飲品項
            foreach (string itemName in list品項名稱)
            {
                lBx冷飲品項.Items.Add(itemName);
            }
            //lBx冷飲品項.SelectedIndex = 1; //預選

            共用.品項杯數 = 1;
            tBx數量.Text = 共用.品項杯數.ToString();
            //甜度
            list甜度.Add("全糖");
            list甜度.Add("半糖");
            list甜度.Add("少糖");
            list甜度.Add("微糖");
            list甜度.Add("無糖");
            foreach (string itemName in list甜度)
            {
                cbx甜度.Items.Add(itemName);
            }
            cbx甜度.SelectedIndex = 0;
            //冰塊
            list冰塊.Add("正常冰");
            list冰塊.Add("少冰");
            list冰塊.Add("微冰");
            list冰塊.Add("去冰");
            list冰塊.Add("溫熱飲");
            foreach (string itemName in list冰塊)
            {
                cbx冰塊.Items.Add(itemName);
            }
            cbx冰塊.SelectedIndex = 0;
            //加料,有價格
            
            list加料.Add("珍珠10元");
            list加料.Add("波霸10元");
            list加料.Add("椰果5元");
            list加料.Add("仙草凍5元");
            list加料.Add("布丁15元");
            foreach (string itemName in list加料)
            {
                lBx配料.Items.Add(itemName);
            }
            
            list加料價格.Add(10);
            list加料價格.Add(10);
            list加料價格.Add(5);
            list加料價格.Add(5);
            list加料價格.Add(15);

            lbl單價.Text = 0 + "元";
        }
        
        public void lBx冷飲品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lBx冷飲品項.SelectedIndex;
            共用.訂購品項 = list品項名稱[selIndex];
            共用.單價 = list品項價格[selIndex];
            lbl單價.Text = 共用.單價.ToString() + "元";
            共用.品項總價 = 共用.品項杯數 * 共用.單價;
            lbl品項總價.Text = 共用.品項總價.ToString() + "元";

            lBx配料.SelectedItems.Clear();
                        
        }
        private void ListBox1_Leave(object sender, EventArgs e) 
        {
            lBx冷飲品項.Update();
        }

        private void cbx甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int selIndex = cbx甜度.SelectedIndex;
            共用.甜度 = list甜度[selIndex];
        }

        private void cbx冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbx冰塊.SelectedIndex;
            共用.冰塊 = list冰塊[selIndex];
        }

        private void lBx配料_SelectedIndexChanged(object sender, EventArgs e)
        {           
            共用.加料 = "";
            共用.加料價格 = 0;
            for (int i = 0; i < lBx配料.Items.Count; i++)
                if (lBx配料.GetSelected(i) == true)
                {
                    共用.加料 += list加料[i];
                    共用.加料價格 += list加料價格[i];
                }
                else
                { 
                }
            共用.加料總價格 = 共用.加料價格 * 共用.品項杯數;
            共用.加料總價格 = 共用.加料價格 * 共用.品項杯數;
            lbl品項總價.Text = (共用.品項總價 + 共用.加料總價格).ToString() + "元";
        }

        private void tBx數量_TextChanged(object sender, EventArgs e)
        {//品項杯數避免與改正輸入錯誤
            try 
            {
                if (tBx數量.Text != "")
                {
                    共用.品項杯數 = Convert.ToInt32(tBx數量.Text);
                    共用.品項杯數 = Convert.ToInt32(tBx數量.Text);
                    共用.品項總價 = 共用.品項杯數 * 共用.單價;
                    共用.加料總價格 = 共用.加料價格 * 共用.品項杯數;
                    lbl品項總價.Text = (共用.品項總價 + 共用.加料總價格).ToString() + "元";
                }
                else
                { 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("輸入格式錯誤,請重新輸入");
                tBx數量.Clear();
                tBx數量.Text= "1";
            }
        }

        private void btn加入訂購單_Click(object sender, EventArgs e)
        {            
            //作業請用自訂類別
            Class1 訂購用 = new Class1();
            訂購用.訂購品項 = 共用.訂購品項;
            訂購用.甜度 = 共用.甜度;
            訂購用.單價 = 共用.單價;
            訂購用.品項總價 = 共用.品項總價 + 共用.加料總價格;
            訂購用.品項杯數 = 共用.品項杯數;
            訂購用.加料價格 = 共用.加料價格;
            訂購用.加料 = 共用.加料;
            訂購用.冰塊 = 共用.冰塊;
            //訂購用.加料總價格 = 共用.加料總價格;
            if (txt訂購人.Text != "" && lBx冷飲品項.SelectedIndex >=0)
            {
                GlobalVar.list訂購品項列表.Add(訂購用);
                GlobalVar.訂購人資訊 = txt訂購人.Text;
                MessageBox.Show("已加入結帳單");
            }
            else
            {
                MessageBox.Show("請確認訂購人姓名及冷飲品項");
            }
        }

        private void btn查看訂購單_Click(object sender, EventArgs e)
        {
            GlobalVar.form菜單 = this;
            Form2 form結帳單 = new Form2();
            GlobalVar.form結帳單 = form結帳單;
            form結帳單.Show();
            this.Hide();            
        }

        public sealed class DoubleBufferedListBox : ListBox
        {
            #region Method Overrides
            /// <summary>
            /// Override OnTemplateListDrawItem to supply an off-screen buffer to event
            /// handlers.
            /// </summary>
            protected override void OnDrawItem(DrawItemEventArgs e)
            {
                BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;

                Rectangle newBounds = new Rectangle(0, 0, e.Bounds.Width, e.Bounds.Height);
                using (BufferedGraphics bufferedGraphics = currentContext.Allocate(e.Graphics, newBounds))
                {
                    DrawItemEventArgs newArgs = new DrawItemEventArgs(
                        bufferedGraphics.Graphics, e.Font, newBounds, e.Index, e.State, e.ForeColor, e.BackColor);

                    // Supply the real OnTemplateListDrawItem with the off-screen graphics context
                    base.OnDrawItem(newArgs);

                    // Wrapper around BitBlt
                    GDI.CopyGraphics(e.Graphics, e.Bounds, bufferedGraphics.Graphics, new Point(0, 0));
                 
                }
            }
            #endregion
        }

        private void lBx冷飲品項_DrawItem(object sender, DrawItemEventArgs e) { var lb = (ListBox)sender; var item = lb.Items[e.Index].ToString(); var brush = Brushes.Black; e.Graphics.DrawString(item, lb.Font, brush, e.Bounds); }

        
    }
}
