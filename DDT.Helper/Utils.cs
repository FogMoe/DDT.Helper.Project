using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DDT.Helper
{
    internal class Utils
        
    {
        public static string jiaodu = "     度";
        public static string lidu = "     力";
        public static string seconds = "约按住   秒";
        // 只能输入小数
        public static void OnlyInputDecimal(System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        
        private static double Enwdpias(string str)
        {
            /*
             // Extract numbers with decimal points in a string
             */
            decimal result =0;
            str = Regex.Replace(str, @"[^\d.\d]", "");
            if (Regex.IsMatch(str, @"^[+-]?\d*[.]?\d*$"))
            {
                result = decimal.Parse(str);
            }
            double n = Convert.ToDouble(result);
            return n;
        }

        // 高抛打法
        public static void DafaGaoPao(double pingju,double fengli)
        {
            lidu = "95.00力";
            jiaodu = (90 - pingju + (fengli * 2)).ToString("F0")+"度";
            seconds = "约按住" + (Enwdpias(lidu) * 0.0575).ToString("F2") + "秒";
        }



        // 20度打法
        public static void Dafa20du(double pingju)
        {
            jiaodu = "20"+"度";
            if (pingju >= 0 && pingju <= 1)
            { 
                lidu =pingju.ToString("F2") +"力";
            }
            else if (pingju>1 && pingju <=2)
            {
                lidu = (10+(pingju-1)/0.11).ToString("F2") + "力";
            }
            else if (pingju > 2 && pingju <= 3)
            {
                lidu = (19 + (pingju - 2) / 0.17).ToString("F2") + "力";
            }
            else if (pingju > 3 && pingju <= 4)
            {
                lidu = (25 + (pingju - 3) / 0.2).ToString("F2") + "力";
            }
            else if (pingju > 4 && pingju <= 5)
            {
                lidu = (30 + (pingju - 4) / 0.17).ToString("F2") + "力";
            }
            else if (pingju > 5 && pingju <= 6)
            {
                lidu = (36 + (pingju - 5) / 0.25).ToString("F2") + "力";
            }
            else if (pingju > 6 && pingju <= 7)
            {
                lidu = (40 + (pingju - 6) / 0.25).ToString("F2") + "力";
            }
            else if (pingju > 7 && pingju <= 8)
            {
                lidu = (44 + (pingju - 7) / 0.25).ToString("F2") + "力";
            }
            else if (pingju > 8 && pingju <= 9)
            {
                lidu = (48 + (pingju - 8) / 0.33).ToString("F2") + "力";
            }
            else if (pingju > 9 && pingju <= 10)
            {
                lidu = (51 + (pingju - 9) / 0.33).ToString("F2") + "力";
            }
            else if (pingju > 10 && pingju <= 11)
            {
                lidu = (54 + (pingju - 10) / 0.33).ToString("F2") + "力";
            }
            else if (pingju > 11 && pingju <= 12)
            {
                lidu = (57 + (pingju - 11) / 0.33).ToString("F2") + "力";
            }
            else if (pingju > 12 && pingju <= 13)
            {
                lidu = (60 + (pingju - 12) / 0.33).ToString("F2") + "力";
            }
            else if (pingju > 13 && pingju <= 14)
            {
                lidu = (63 + (pingju - 13) / 0.33).ToString("F2") + "力";
            }
            else if (pingju > 14 && pingju <= 15)
            {
                lidu = (66 + (pingju - 14) / 0.33).ToString("F2") + "力";
            }
            else if (pingju > 15 && pingju <= 16)
            {
                lidu = (69 + (pingju - 15) / 0.33).ToString("F2") + "力";
            }
            else if (pingju > 16 && pingju <= 17)
            {
                lidu = (72 + (pingju - 16) / 0.33).ToString("F2") + "力";
            }
            else if (pingju > 17 && pingju <= 18)
            {
                lidu = (74 + (pingju - 17) / 0.5).ToString("F2") + "力";
            }
            else if (pingju > 18 && pingju <= 19)
            {
                lidu = (76 + (pingju - 18) / 0.5).ToString("F2") + "力";
            }
            else if (pingju > 19 && pingju <= 20)
            {
                lidu = (78 + (pingju - 19) / 0.5).ToString("F2") + "力";
            }
            else if (pingju > 20)
            {
                lidu = (80 + (pingju - 20) / 1).ToString("F2") + "力";
            }

            seconds = "约按住" + (Enwdpias(lidu) * 0.0575).ToString("F2") + "秒";

        }



        



    }
}
