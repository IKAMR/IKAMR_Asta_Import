using Asta_import.Properties;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Asta_import
{
    public partial class Form1 : Form
    {
        //----------------------------------------------------------------------------------------------
        Microsoft.Office.Interop.Excel.Application xlApp;

        ListConverter converter = new ListConverter();

        string inFile = String.Empty;
        string outFile = String.Empty;

        public string komNavn;

        Hashtable myHashtable;
        //----------------------------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();

            Text = Globals.toolName + " " + Globals.toolVersion;

            txtBxKomNr.Text = Settings.Default.komNavn;
            txtBxLand.Text = Settings.Default.landKode;
            txtBxFylke.Text = Settings.Default.fylkeNr;
            txtBxDepInst.Text = Settings.Default.depInst;

            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            this.DragEnter += new DragEventHandler(Form1_DragEnter);

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel er ikke installert!!");
                return;
            }
            else
            {
                Console.WriteLine("Excel Ok!");
            }

            xlApp.Quit();

            Marshal.ReleaseComObject(xlApp);
        }
        //----------------------------------------------------------------------------------------------

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        //----------------------------------------------------------------------------------------------

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            CheckExcellProcesses();
            string fileName = "No file added";

            txtBxLog.Clear();

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (files.Count() > 1)
            {
                txtBxLog.Text = "Vennligst bare en fil av gangen... ;D";
            }
            else
            {
                fileName = files[0].ToString();
                inFile = fileName;
                txtBxInFile.Text = inFile;

            }


        }
        //----------------------------------------------------------------------------------------------

        private void btnStartConv_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inFile))
            {
                txtBxLog.Text = "Vennligst dropp innfil på programmet!";

            }
            else if (String.IsNullOrEmpty(txtBxOutFile.Text))
            {
                txtBxLog.Text = "Vennligst legg inn navn på resultatfil!";
            }
            else if (String.IsNullOrEmpty(txtBxKomNr.Text))
            {
                txtBxLog.Text = "Vennligst legg inn kommunenummer!";
            }
            else
            {

                Settings.Default.komNavn = txtBxKomNr.Text;
                Settings.Default.landKode = txtBxLand.Text;
                Settings.Default.fylkeNr = txtBxFylke.Text;
                Settings.Default.depInst = txtBxDepInst.Text;
                Settings.Default.Save();

                //converter.ConvertList(inFile, outFile);
                btnStartConv.Enabled = false;
                this.AllowDrop = false;

                backgroundWorker1 = new BackgroundWorker();
                backgroundWorker1.DoWork += backgroundWorker1_DoWork;
                backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
                backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.RunWorkerAsync();
            }



        }
        //----------------------------------------------------------------------------------------------

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            converter.OnProgressUpdate += convert_OnProgressUpdate;



            string outFolder = Directory.GetParent(inFile).ToString();
            //string outFolder = @"C:\developer\c#\asta_import\doc";

            outFile = Path.Combine(outFolder, txtBxOutFile.Text);

            backgroundWorker1.ReportProgress(0, "Starter konvertering av: " + inFile);

            converter.ConvertList(inFile, outFile);


        }
        //----------------------------------------------------------------------------------------------

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            txtBxLog.Text = e.UserState.ToString();
        }
        //----------------------------------------------------------------------------------------------

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                txtBxLog.Text = "ERROR: " + e.Error.Message;
                KillExcel();
            }
            else
            {
                txtBxLog.Text = "Konvertering ferdig";
                txtBxLog.AppendText("\r\nResultat finnes her: " + outFile);
                btnStartConv.Enabled = true;
                this.AllowDrop = true;

                KillExcel();
            }

        }
        //----------------------------------------------------------------------------------------------

        private void KillExcel()
        {
            Process[] AllProcesses = Process.GetProcessesByName("excel");

            // check to kill the right process
            foreach (Process ExcelProcess in AllProcesses)
            {
                if (myHashtable.ContainsKey(ExcelProcess.Id) == false)
                    ExcelProcess.Kill();
            }

            AllProcesses = null;
        }
        //----------------------------------------------------------------------------------------------

        private void CheckExcellProcesses()
        {
            Process[] AllProcesses = Process.GetProcessesByName("excel");
            myHashtable = new Hashtable();
            int iCount = 0;

            foreach (Process ExcelProcess in AllProcesses)
            {
                myHashtable.Add(ExcelProcess.Id, iCount);
                iCount = iCount + 1;
            }
        }
        //----------------------------------------------------------------------------------------------

        private void convert_OnProgressUpdate(string statusMsg)
        {
            base.Invoke((System.Action)delegate
            {
                backgroundWorker1.ReportProgress(0, statusMsg);

            });
        }


    }
    public static class Globals
    {
        public static readonly String toolName = "IKAMR Asta import";
        public static readonly String toolVersion = "0.1";
    }


}
