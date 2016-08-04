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

namespace Zadanie_str_431
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private bool formChanged;
        private string folderPath;
        private Excuse currentExcuse = new Excuse();

        private void updateForm (bool changed)
        {
            if (!changed)
            {
                this.excuseTextBox.Text = currentExcuse.Decsription;
                this.resultsTextBox.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    showDateLabel.Text = File.GetLastAccessTime(currentExcuse.ExcusePath).ToString();
                    this.Text = "Excuse Manager";
                }
                else
                {
                    this.Text = "Excuse Manager*";
                    this.formChanged = changed;
                }
                
                }
            }
        
        private void folderButton_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                openButton.Enabled = true;
                saveButton.Enabled = true;
                randomButton.Enabled = true;

            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = folderPath;
            saveFileDialog1.Filter = "text file|.txt|All files|*.*";
            saveFileDialog1.FileName = excuseTextBox.Text + ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(excuseTextBox.Text);
                    sw.WriteLine(resultsTextBox.Text);
                    sw.WriteLine(lastUsed.ToString());

                }
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}
