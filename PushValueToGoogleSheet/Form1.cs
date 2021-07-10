using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushValueToGoogleSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath;
        string filePathSave;
        private void browserBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            filePathTxt.Text = open.FileName;
            filePath = open.FileName;
        }

        private void pushToGoogleBtn_Click(object sender, EventArgs e)
        {
            string sheetID = sheetIdTxt.Text;
            string range = nameTabTxt.Text;
            PushValueToGoogleSheetHelper pushValueToGoogle = new PushValueToGoogleSheetHelper();
            pushValueToGoogle.getLastLineGoogleSheet(sheetID, range);
            int  rawGooleSheet = pushValueToGoogle.number;
            pushValueToGoogle.PushValueToGoogle(rawGooleSheet, sheetID, filePath, range);
            pushValueToGoogle.ClearCache(filePath);
            MessageBox.Show("Push data into google sheet success!!!!");
        }

        private void getGoogleSheetBtn_Click(object sender, EventArgs e)
        {
            string spreadsheetId = sheetIdTxt.Text;
            string range = nameTabTxt.Text;
            PushValueToGoogleSheetHelper pushValueToGoogle = new PushValueToGoogleSheetHelper();
            pushValueToGoogle.getGoogleSheet(spreadsheetId,range);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter($"{filePathSave}.txt", true))
            {
                foreach (String s in pushValueToGoogle.list)
                    file.WriteLine(s);
            }
            MessageBox.Show("Get data from google sheet success!!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
            filePathSave = saveFile.FileName;
            fileNameSaveTxt.Text = saveFile.FileName;
        }
    }
}
