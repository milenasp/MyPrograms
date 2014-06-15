using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            string[] input = txtInput.Text.Split(new char[] {',', ' ', '.'});
            List<string> inputList = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != "")
                {
                    inputList.Add(input[i]); 
                }
            }

            string month = inputList[0];
            string date = inputList[1];
            string year = inputList[2];
            string day = date;

            if (day[0] == '0')
            {
                day = day.TrimStart('0'); 
            }

            switch (month)
            {
                case "Jan": month = "January"; break;
                case "Feb": month = "February"; break;
                case "Mar": month = "March"; break;
                case "Apr": month = "April"; break;
                case "May": month = "May"; break;
                case "Jun": month = "June"; break;
                case "Jul": month = "July"; break;
                case "Aug": month = "August"; break;
                case "Sep": month = "September"; break;
                case "Oct": month = "October"; break;
                case "Nov": month = "November"; break;
                case "Dec": month = "December"; break;
            }

            string outputStr = "" + day + " " + month + " " + year; 
            txtOutput.Text = outputStr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outputBox_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }
    }
}
