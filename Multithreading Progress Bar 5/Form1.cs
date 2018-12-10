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

namespace Multithreading_Progress_Bar_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; // Thread controls is manuel.
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private ManualResetEvent FirstMre = new ManualResetEvent(true);
        private ManualResetEvent SecondMre = new ManualResetEvent(true);
        private ManualResetEvent ThirdMre = new ManualResetEvent(true);

        Thread FirstTh, SecondTh, ThirdTh; 

        private void Run_FirstProgressBar()
        {

            for (int i = 0; i <= 100; i++)
            {
                FirstMre.WaitOne(); //FirstMre begins to wait for the signal to arrive
                progressBar1.Value = i;
                Thread.Sleep(100); // Animation speed slowed

            }
        }

        private void Run_SecondProgressBar()
        {
                for (int i = 0; i <= 100; i++)
                {
                    SecondMre.WaitOne(); //SecondMre begins to wait for the signal to arrive
                    progressBar2.Value = i;
                    Thread.Sleep(100); // Animation speed slowed
            }
        }

        private void Run_ThirdProgressBar()
        {
            for (int i = 0; i <= 100; i++)
            {
                ThirdMre.WaitOne();//ThirdMre begins to wait for the signal to arrive
                progressBar3.Value = i;
                Thread.Sleep(100); //Animation speed slowed
            }
        }

        //----------------------START BUTTONS----------------------\\
        private void firstStart_Click(object sender, EventArgs e)
        {
            FirstTh = new Thread(Run_FirstProgressBar); // First thread create
            if (FirstTh.ThreadState == ThreadState.Unstarted)
                FirstTh.Start(); //First thread starts
            FirstMre.Set(); //FirstMre(ManuelResetEvent) Object is set
        }

        private void secondStart_Click(object sender, EventArgs e)
        {
            SecondTh = new Thread(Run_SecondProgressBar); // Second thread create
            if (SecondTh.ThreadState == ThreadState.Unstarted)
                SecondTh.Start(); //Second thread starts
            SecondMre.Set(); //SecondMre(ManuelResetEvent) Object is set
        }

        private void thirdStart_Click(object sender, EventArgs e)
        {
            ThirdTh = new Thread(Run_ThirdProgressBar); // Third thread create
            if (ThirdTh.ThreadState == ThreadState.Unstarted) 
                ThirdTh.Start(); // Third thread starts
            ThirdMre.Set(); //ThirdMre(ManuelResetEvent) Object is set
        }

        //----------------------PAUSE BUTTONS----------------------\\
        private void firstPause_Click(object sender, EventArgs e)
        {
            if (FirstTh != null && FirstTh.IsAlive)
            {
                FirstTh.Suspend(); 
            }
            if (FirstTh != null && FirstTh.ThreadState == ThreadState.Suspended)
            {
                FirstTh.Resume();
            }
        }

        private void secondPause_Click(object sender, EventArgs e)
        {
            if (SecondTh != null && SecondTh.IsAlive)
            {
                SecondTh.Suspend();
            }
            if (SecondTh != null && SecondTh.ThreadState == ThreadState.Suspended)
            {
                SecondTh.Resume();
            }
        }


        private void thirdPause_Click_1(object sender, EventArgs e)
        {
            if (ThirdTh != null && ThirdTh.IsAlive)
            {
                ThirdTh.Suspend();
            }
            if (ThirdTh != null && ThirdTh.ThreadState == ThreadState.Suspended)
            {
                ThirdTh.Resume();
            }
        }

        //----------------------STOP BUTTONS----------------------\\
        private void firstStop_Click(object sender, EventArgs e)
        {
            FirstMre.Reset();
            progressBar1.Value = 0;
        }

        private void secondStop_Click(object sender, EventArgs e)
        {
            SecondMre.Reset();
            progressBar2.Value = 0;
        }

        private void thirdStop_Click(object sender, EventArgs e)
        {
            ThirdMre.Reset();
            progressBar3.Value = 0;
        }

    }
}
