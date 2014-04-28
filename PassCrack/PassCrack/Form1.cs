using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassCrack
{

    delegate void SetTextCallback(string text);

    public partial class PassCrackForm : Form
    {

        private bool found = false;
        private int wordCount = 0;
        private Thread hashingThread;
        private Thread timerThread;
        private Stopwatch watch;
        private TimeSpan ts;
        private OpenFileDialog openFile;
        private StreamReader fileStream;
        private String fileName = "";
        private String inputHashString = "";
        
        public PassCrackForm()
        {
            InitializeComponent();
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {

            openFile = new OpenFileDialog();
            openFile.Title = "Select a Dictionary";
            openFile.Filter = "Text Files | *.txt";
            openFile.InitialDirectory = "%HOMEPATH%";
            openFile.Multiselect = false;

            try
            {

                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    fileName = openFile.FileName;
                    fileSelLbl.Text = fileName;

                }

            }

            catch (Exception fileOpenErr)
            {

                MessageBox.Show("ERROR: Could not read dictionary file from auxiliary storage.  Original error: " + fileOpenErr.Message, "PassCrack Password Cracker", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void hashInputField_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                inputHashString = hashInputField.Text;

            }

        }

        private void crackBtn_Click(object sender, EventArgs e)
        {

            inputHashString = hashInputField.Text;
            hashingThread = new Thread(new ThreadStart(findHash));
            timerThread = new Thread(new ThreadStart(stopWatch));

            try
            {

                hashingThread.Start();
            
            }

            catch (ThreadStateException)
            {

                MessageBox.Show("ERROR:  Could not start hashing thread.  Please close the program and try again.", "PassCrack Password Cracker", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }

        }

        private void findHash()
        {

            try
            {

                timerThread.Start();

            }

            catch(ThreadStateException)
            {

                MessageBox.Show("ERROR:  Could not start hashing thread.  Please close the program and try again.", "PassCrack Password Cracker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (String.IsNullOrEmpty(fileName) == true)
            {

                MessageBox.Show("ERROR:  Dictionary path empty.  Please select a dictionary file in .txt format.", "PassCrack Password Cracker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            fileStream = new StreamReader(fileName);
            ASCIIEncoding ae = new ASCIIEncoding();
            StringBuilder strBuild = new StringBuilder();
            byte[] hashBytes;
            String inputString;
            MD5CryptoServiceProvider mDigest = new MD5CryptoServiceProvider();

            while ((fileStream.EndOfStream == false) && (found == false))
            {

                inputString = fileStream.ReadLine();
                hashBytes = mDigest.ComputeHash(ae.GetBytes(inputString));
                wordCount++;
                safeSetCurrentWordLblText(inputString);
                safeSetWordCountLblText(wordCount.ToString());

                for (int i = 0; i < hashBytes.Length; i++)
                {

                    strBuild.Append(hashBytes[i].ToString("x2").ToLower());

                }

                safeSetCurrentHashLblText(strBuild.ToString());

                if (String.Compare(strBuild.ToString(), inputHashString) == 0)
                {

                    found = true;
                    safeSetPasswdResLblText(inputString);
                    watch.Stop();
                    MessageBox.Show("Password found!  The password is \'" + inputString + "\'.", "PassCrack Password Cracker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }

                strBuild.Clear();

            }

            if (found == false)
            {

                MessageBox.Show("Password not found!  The dictionary does not contain the password.  Please try another dictionary file.", "PassCrack Password Cracker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

        }

        private void stopWatch()
        {

            String timeStr;
            watch = new Stopwatch();
            watch.Start();

            while (watch.IsRunning == true)
            {

                ts = watch.Elapsed;
                timeStr = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                safeSetTimeLblText(timeStr);

            }

        }

        private void safeSetCurrentWordLblText(String update)
        {

            if (this.currentWordLbl.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(safeSetCurrentWordLblText);
                this.Invoke(d, new object[] { update });

            }

            else
            {

                this.currentWordLbl.Text = update;

            }

        }

        private void safeSetWordCountLblText(String update)
        {

            if (this.wordCountNumLbl.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(safeSetWordCountLblText);
                this.Invoke(d, new object[] { update });

            }

            else
            {

                this.wordCountNumLbl.Text = update;

            }

        }

        private void safeSetCurrentHashLblText(String update)
        {

            if(this.currentHashLbl.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(safeSetCurrentHashLblText);
                this.Invoke(d, new object[] { update });
                

            }

            else
            {

                this.currentHashLbl.Text = update;

            }

        }

        private void safeSetPasswdResLblText(String update)
        {

            if (this.passwdResLbl.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(safeSetPasswdResLblText);
                this.Invoke(d, new object[] { update });

            }

            else
            {

                this.passwdResLbl.Text = update;
                this.passwdResLbl.ForeColor = Color.Lime;

            }

        }

        private void safeSetTimeLblText(String update)
        {

            if (this.timeLbl.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(safeSetTimeLblText);
                this.Invoke(d, new object[] { update });

            }

            else
            {

                this.timeLbl.Text = update;

            }

        }

        private void PassCrackForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            timerThread.Abort();
            hashingThread.Abort();
            Application.Exit();

        }

    }

}