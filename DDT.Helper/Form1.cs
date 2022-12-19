using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDT.Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.TopMost = true;
            }
            else{
                this.TopMost = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open a website
            System.Diagnostics.Process.Start("https://github.com/FogMoe/DDT.Helper");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入小数
            Utils.OnlyInputDecimal(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.OnlyInputDecimal(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("请输入正确的参数！");
                return;
            }
            double pingju = Convert.ToDouble(textBox1.Text);
            double fengli = 0.0;
            if (radioButton5.Checked)
            {
                //逆风变负数
                fengli = -Convert.ToDouble(textBox2.Text);
            }
            else if (radioButton6.Checked)
            {
                //顺风正数
                fengli = Convert.ToDouble(textBox2.Text);
            }
            if (pingju > 40 || fengli >10)
            {
                MessageBox.Show("请输入正确的参数！");
                return;
            }

            if (radioButton1.Checked)
            {   
                //20
                Utils.Dafa20du(pingju);
                label8.Text = radioButton1.Text + ",屛距" + textBox1.Text+"。";
            }
            else if (radioButton3.Checked)
            {
                //高抛
                Utils.DafaGaoPao(pingju, fengli);
                label8.Text = radioButton3.Text + ",屛距" + textBox1.Text + ",\r"+"风力"+fengli.ToString()+ "。";
            }
            label5.Text = Utils.jiaodu;
            label6.Text = Utils.lidu;
            label11.Text = Utils.seconds;
            


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = false;
            }
            else if(radioButton1.Checked == false)
            {
                groupBox2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://file1.fogmoe.top/Donate/AliPay.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://file1.fogmoe.top/Donate/WechatPay.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://file1.fogmoe.top/Donate/QQPay.png");
        }
    }
}
