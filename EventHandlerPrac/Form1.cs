using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            MessageBox.Show(btn.Text+" 버튼이 클릭되었습니다.");

/*            switch (btn)
            {
                case button1:
                    break;
            }*/
        }

        // frame창 닫힐때
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(e.CloseReason.ToString()); //UserClosing
        }


        private int elapsedTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            textBox1.Text = elapsedTime + "초 경과";
            label1.Text = elapsedTime + "초 경과";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //타이머 켜추기
            timer1.Enabled = !timer1.Enabled; //켜져있을땐 끄고, 꺼져있을땐 켜주기
        }
    }
}
