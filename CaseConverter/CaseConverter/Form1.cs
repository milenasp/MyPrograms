using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization; 

namespace CaseConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sentenceCase_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text;
            input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input); 

            outputBox.Text = input; 
        }

        private void upperCase_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text;
            input = input.ToUpper();

            outputBox.Text = input; 
            
        }

        private void lowerCase_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text;
            input = input.ToLower();

            outputBox.Text = input; 
        }

        private void capitalisedCase_Click(object sender, EventArgs e)
        {

        }

        private void capitalisedCase_Click_1(object sender, EventArgs e)
        {
            string input = inputBox.Text;
            char[] array = input.ToCharArray();

            array[0] = Char.ToUpper(array[0]);
            int spaceIndex = input.IndexOf(' ');

            while (spaceIndex != -1)
            {
                array[spaceIndex + 1] = Char.ToUpper(array[spaceIndex + 1]);
                spaceIndex = input.IndexOf(' ', spaceIndex + 1); 
            }

            StringBuilder outputStr = new StringBuilder(); 
            for (int i = 0; i < array.Length; i++)
			{
			    outputStr.Append(array[i]); 
			}
            outputBox.Text = outputStr.ToString(); 
        }

        private void alternateCase_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text;
            char[] array = input.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    array[i] = Char.ToUpper(array[i]); 
                }
            }

            StringBuilder outputStr = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                outputStr.Append(array[i]);
            }
            outputBox.Text = outputStr.ToString(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
