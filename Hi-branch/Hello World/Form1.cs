using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        private delegate void DelShowMessage();

        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            labHelloWorld.Text = "Hello World !";

        }

        async private void btnCount_Click(object sender, EventArgs e)
        {

            for (int count = 0; count <= 10; count++)
            {
                labCount.Text = count.ToString();
                await Task.Delay(100);

            }
            //本來想寫Thread.Sleep()失敗改用Task.Delay()


        }
        private void button1_Click(object sender, EventArgs e)//UI下執行緒
        {
            //Thread thread = new Thread(new ThreadStart(DoWork));
            //thread.Start();
            Thread thrStart = new Thread(ShowMessage);
            thrStart.Start();

        }

        private void AddMessage()//labCount.Text不可再UI執行緒下
        {
            //是否為跨執行緒如若是(True)則委派執行；如若否則為同執行緒直接執行
            if (this.InvokeRequired)// 非同執行緒
            {
                DelShowMessage del = new DelShowMessage(AddMessage);//利用委派執行此方法
                this.Invoke(del);//呼叫自己
            }
            else //同執行緒
            {
                    labCount.Text = count.ToString();

            }
        }

        private void ShowMessage()       
        {
            for (count = 0; count <= 10; count++)
            {
                    AddMessage();//labCount.Text執行緒
                    Thread.Sleep(100);//內建Sleep執行緒
          
            }
        }

        public void DoWork()
        {
            for (count = 0; count <= 10; count++)
            {
                labCount.Text = count.ToString();
                Thread.Sleep(1000);
            }
        }
        private void btnTime_Click(object sender, EventArgs e)
        {
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = System.DateTime.Now.ToString(" yyyy/MM/dd HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (count = 0; count <= 10; count++)
            {
                labCount.Text = count.ToString();
                sleep();
            }

        }

        private void sleep()
        {
            if (this.InvokeRequired)
            {
                DelShowMessage dels = new DelShowMessage(sleep);
                this.Invoke(dels);
            }
            else
            {
                Thread.Sleep(100);

            }

        }
    }
}
