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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form1 mainForm1 = null;
        public Form2(Form callingForm)
        {
            mainForm1 = callingForm as Form1;
            InitializeComponent();
        }

        //OK button
        private void Button1_Click(object sender, EventArgs e)
        {
            mainForm1.MessageBox = mainForm1.MessageBox += richTextBox2.Text;
            
            //show error message if no input from the user
            if (string.IsNullOrWhiteSpace(richTextBox2.Text))
            {
                string caption = "Error";
                string message = "Please, input description";
                
                MessageBox.Show(message, caption);
                return;
            }

            //add last changes to .txt file
            File.WriteAllText("text.txt", string.Format("{0}{1}", mainForm1.MessageBox, Environment.NewLine));
            this.Close();
        }

        //cancel button
        private void Button2_Click(object sender, EventArgs e)
        {
            //add lats changes to .txt file
            File.WriteAllText("text.txt", string.Format("{0}{1}", mainForm1.MessageBox, Environment.NewLine));
            this.Close();
        }        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
