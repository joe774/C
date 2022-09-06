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
using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{
    class Class1
    {
       public int 品項杯數 = 0;
       public int 單價 = 0;
       public int 品項總價 = 0;
       public string 訂購品項 = "";
       public string 甜度 = "";
       public string 冰塊 = "";
       public string 加料 = "";
       public int 加料價格 = 0;
       public int 加料總價格 = 0;
    }

    public static class GDI
    {
        private const UInt32 SRCCOPY = 0x00CC0020;

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, UInt32 dwRop);

        public static void CopyGraphics(Graphics g, Rectangle bounds, Graphics bufferedGraphics, Point p)
        {
            IntPtr hdc1 = g.GetHdc();
            IntPtr hdc2 = bufferedGraphics.GetHdc();

            BitBlt(hdc1, bounds.X, bounds.Y,
                bounds.Width, bounds.Height, hdc2, p.X, p.Y, SRCCOPY);

            g.ReleaseHdc(hdc1);
            bufferedGraphics.ReleaseHdc(hdc2);
        }
    }

}


