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
    class GlobalVar
    {
        public static string 訂購人資訊 = "";
        public static List<Class1> list訂購品項列表 = new List<Class1>();
        //作業:品項資訊要由arraylist改成自訂類別class(參考person)
        public static Form1 form菜單;
        public static Form2 form結帳單;
    }
}
