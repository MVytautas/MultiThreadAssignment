using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadAssignment
{
    public partial class Form : System.Windows.Forms.Form
    {
        double percentPercent = 0;
        double percentPerEntry = 0;
        private bool StopButton1WasClicked = false;
        public Form()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void startButton_Click(object sender, EventArgs e) // Creates threads and entries
        {
            var numberOfThreads = int.Parse(ThreadTextBox.Text);
            var numberOfEntries = int.Parse(EntriesTextBox.Text);
            percentPerEntry = 1 / (double)numberOfEntries * 100;
            for (var  i = 0; i < numberOfThreads; i++)
            {
                var entryPerThread = numberOfEntries / (numberOfThreads - i);
                numberOfEntries -= entryPerThread;
                //create thread
                //var myThread = new System.Threading.Thread(new System.Threading.ThreadStart(() => InsertEntities(i, entryPerThread)));
                //myThread.Start();

                Task task = new Task(() => InsertEntities(i, entryPerThread));
                task.Start();
                task.Wait();
                //var button = stopButton.PerformClick();
                //stopButton_Click(new object(), new EventArgs());
                //if (StopButton1WasClicked = true)
                //{
                //    break;
                //}
            }
        }

        private async void InsertEntities(int threadId, int numberOfEntities) // insert asynchronous data
        {
            await Task.Run(() => Insert(threadId, numberOfEntities)); ;
        }

        async void Insert(int threadId, int numberOfEntities) // Insert data to db
        {
            masterEntities _db = new masterEntities();
            for (int i = 0; i < numberOfEntities; i++)
            {
                var newItem = new Thread
                {
                    ThreadId = threadId,
                    Text = RandomString(4)
                };
                _db.Threads.Add(newItem);
                _db.SaveChanges();
                percentPercent += percentPerEntry; // currentVal / totalVal
                this.SetProgressBar((int)percentPercent);

                if (StopButton1WasClicked == true)
                {
                    break;
                }
            }
        }

        private string RandomString(int length) // Create random input
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        delegate void SetProgressBarCallback(int percentage);
        private void SetProgressBar(int percentage) // Progress bar method
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.progressBar1.InvokeRequired)
            {
                SetProgressBarCallback d = new SetProgressBarCallback(SetProgressBar);
                this.Invoke(d, new object[] { percentage });
            }
            else
            {
                this.progressBar1.Value = percentage;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopButton1WasClicked = true;
        }
}
}
