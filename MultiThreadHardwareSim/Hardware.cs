﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace MultiThreadHardwareSim
{
    public partial class Hardware : Form
    {
        private List<string> finalResults;

        public Hardware()
        {
            InitializeComponent();
            finalResults = new List<string>();
        }

        private void buttonConnectDevice_Click(object sender, EventArgs e)
        {
            try
            {
                using (WaitingDialog frm = new WaitingDialog(CheckDeviceConnection, DeviceChoiceEnum.PS3))
                {
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                radioButtonSingleSiteEnable.Checked = false;
            }

        }

        private void buttonProgram_Click(object sender, EventArgs e)
        {
            finalResults.Clear();
            try
            {
                Stopwatch time = new Stopwatch();
                time.Start();

                using (WaitingDialog frm = new WaitingDialog(ProgramDevice, DeviceChoiceEnum.PS3))
                {
                    frm.ShowDialog();
                }
                updateTextBox();
                time.Stop();
                MessageBox.Show(time.ElapsedMilliseconds.ToString() + "ms");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                radioButtonSingleSiteEnable.Checked = false;
            }

        }

        private void updateTextBox()
        {
            TextBox[] textBoxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4 };

            for (int i = 0; i < finalResults.Count; i++)
            {
                textBoxes[i].Text = finalResults[i];
            }
           
        }

        private void CheckDeviceConnection<T>(T deviceChoiceEnum)
        {
            try
            {
                int goodDeviceCount = HWDLL.CheckHardwareDevice(deviceChoiceEnum);
                MessageBox.Show("Good device count: " + goodDeviceCount);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ProgramDevice<T>(T deviceChoiceEnum)
        {
            try
            {
                HWDLL.CheckHardwareDevice(deviceChoiceEnum);

                List<Thread> workers = new List<Thread>();
                foreach (HWDLL device in HWDLL.Devices)
                {
                    ParameterizedThreadStart ptStart = new ParameterizedThreadStart(ProgramDeviceThread);
                    Thread t = new Thread(ptStart);
                    t.Start(device);
                    workers.Add(t);
                    if (radioButtonSingleSiteEnable.Checked)
                        t.Join();
                }

                if (!radioButtonSingleSiteEnable.Checked)
                {
                    foreach (Thread worker in workers)
                    {
                        worker.Join();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ProgramDeviceThread(object deviceObj)
        {
            try
            {
                string statuss_result = "";
                int status = HWDLL.InstallHardwareDevice(deviceObj);
                if (status == 0)
                {
                    statuss_result = "Successfully programmed " + deviceObj.ToString();
                    finalResults.Add(statuss_result);
                    //MessageBox.Show(statuss_result.ToString());
                }
                else
                {
                    finalResults.Add("Failure status: " + status.ToString() + ". Device: " + deviceObj.ToString());
                    //throw new Exception("Failure status: " + status.ToString() + ". Device: " + deviceObj.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }


}
