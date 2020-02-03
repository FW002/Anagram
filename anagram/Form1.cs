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

namespace anagram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void FileHandle(string input)
        {
            
            string filename = "words.txt";
            StreamReader sr;
            try
            {              
                sr = new StreamReader(filename);
                progress_l.Text = "File Found";

            }
            catch (Exception ex)
            {
                progress_l.Text = "File Not Found";
                MessageBox.Show("File error");
                return;
            }

               sr.BaseStream.Seek(0, SeekOrigin.Begin);
  
                string[] lines = File.ReadAllLines(filename);
                verify(lines, input);                            
            


            sr.Close();
        }

        private void verify(string[] textlines, string input)
        {
            foreach(string l in textlines)
            {
                if (input == l)
                {
                    algorithm(input);
                    break;
                }
                else
                {
                    stat.Text = "' " + input + " '" + "  is not a valid word";
                }
               
            }
           
        }


        private void algorithm(string input)
        {
            stat.Text = "' " + input + " '" + "  is valid";
            
            //Code goes here
        }


        private void OnGoClick(object sender, EventArgs e)
        {
            string input = InputBox.Text;
            FileHandle(input);
          
        }


    }
}
