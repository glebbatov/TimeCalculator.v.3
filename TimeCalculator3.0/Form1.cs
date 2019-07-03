using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;


namespace TimeCalculator3._0
{
    public partial class Form1 : Form
    {
        DateTime startTime;
        DateTime stopTime;
        string defaultTextFile = @"text.txt";
        
        public Form1()
        {           
            InitializeComponent();            

            //open data from text.txt to mainTextForm
            mainTextForm.Text = (File.ReadAllText(defaultTextFile));

            //put cursor in the end of text
            mainTextForm.Focus();
            mainTextForm.SelectionStart = mainTextForm.Text.Length;

            clockout.Enabled = false;
        }

        //clockin button
        private void Clockin_Click(object sender, EventArgs e)
        {           
            if (defaultTextFile.Length >= 0)
                {
                    mainTextForm.AppendText(Environment.NewLine); //start from the new line in the mainTextForm
                }
            File.AppendAllText(defaultTextFile, mainTextForm.Text + Environment.NewLine); //start from the new line in the .txt

            startTime = DateTime.Now;
            mainTextForm.AppendText(startTime.ToString("MM/dd"));
            mainTextForm.AppendText(" "); //separator
            mainTextForm.AppendText(startTime.ToString("hh:mm tt"));
            mainTextForm.AppendText(" - "); //separator

            //put cursor in the end of text
            mainTextForm.Focus();
            mainTextForm.SelectionStart = mainTextForm.Text.Length;

            clockin.Enabled = false;
            clockout.Enabled = true;
        }

        //clockout button
        private void Clockout_Click(object sender, EventArgs e)
        {
            stopTime = DateTime.Now;            
            mainTextForm.AppendText(stopTime.ToString("hh:mm tt"));

            TimeSpan timeWorked = new TimeSpan();
            timeWorked = stopTime - startTime;
            mainTextForm.AppendText(" | "); //separator
            mainTextForm.AppendText(string.Format("{00:00}:{01:00}", 
                (int)timeWorked.TotalHours, Math.Abs(stopTime.Minute - startTime.Minute)));            

            mainTextForm.AppendText((" | ")); //separator          

            //open Form2
            Form2 form2 = new Form2(this);
            form2.Show();            

            clockin.Enabled = true;
            clockout.Enabled = false;
        }

        //return inputed string from Form2
        public string MessageBox
        {
            get { return mainTextForm.Text; }
            set { mainTextForm.Text = value; }            
        }

        //close button
        public void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //save changes button       
        public void SaveChanges_Click(object sender, EventArgs e)
        {
            File.WriteAllText(defaultTextFile, mainTextForm.Text);
        }

        //clock right-bottom
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeTextBox1.Text = DateTime.Now.ToString("MM/dd/yyyy");
            timeTextBox2.Text = DateTime.Now.ToString("hh:mm:ss tt");
            clockTimer.Start();
        }

        //open custom file to mainTextForm
        //(!)error/ copy all changes from mainTrxtForm to text.txt from opened files
        private void readCustomFile_Click(object sender, EventArgs e)
        {
            Stream readCustomFile;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a *.txt File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((readCustomFile = openFileDialog1.OpenFile()) != null)
                {
                    string strFileName = openFileDialog1.FileName;
                    string fileText = File.ReadAllText(strFileName);
                    mainTextForm.Text = fileText;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void mainTextForm_TextChanged(object sender, EventArgs e)
        {

        }
        private void time_Click(object sender, EventArgs e)
        {

        }
    }
}
