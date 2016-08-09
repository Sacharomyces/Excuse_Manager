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

            currentExcuse.LastUsed = lastUsed.Value.Date;
        }

        private bool formChanged = false;
        private string folderPath = "";
        private Excuse currentExcuse = new Excuse();
        Random random = new Random();
        public string LastSavedFilename { get; set; } = "";

        private void updateForm(bool changed)
        {
            if (!changed)
            {
                this.excuseTextBox.Text = currentExcuse.Description;
                this.resultsTextBox.Text = currentExcuse.Results;
                this.lastUsed.Format = DateTimePickerFormat.Long;
                this.lastUsed.Value =currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    showDateLabel.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Excuse Manager";
                this.LastSavedFilename = currentExcuse.Description;
            }
            else
            
                this.Text = "Excuse Manager*";
                this.formChanged = changed;
            }


       

        private void folderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = folderPath;

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
            if (checkChanged())
            {
                openFileDialog1.InitialDirectory = folderPath;
                openFileDialog1.Filter = "text file|*.txt|All files|*.*";
                openFileDialog1.FileName = LastSavedFilename + ".txt";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    updateForm(false);


                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(currentExcuse.Description) || String.IsNullOrEmpty(currentExcuse.Results))
            {
                MessageBox.Show("Please specify an excuse and a result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = folderPath;
            saveFileDialog1.Filter = "text file|*.txt|All files|*.*";
            saveFileDialog1.FileName = LastSavedFilename + ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentExcuse.SaveFile(saveFileDialog1.FileName);
                updateForm(false);
                MessageBox.Show("Excuse saved!");
            }
        }

        private bool checkChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes. Proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)

                    return false;
            }
            return true;
        }
        
        private void excuseTextBox_TextChanged(object sender, EventArgs e)
        {
            
                currentExcuse.Description = excuseTextBox.Text;
                updateForm(true);
            
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            
                currentExcuse.LastUsed = lastUsed.Value;
                updateForm(true);
            
        }
        private void resultsTextBox_TextChanged(object sender, EventArgs e)
        {
           
                currentExcuse.Results = resultsTextBox.Text;
                updateForm(true);
            
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (checkChanged())
            {
                currentExcuse = new Excuse(random,folderPath);
                updateForm(false);
                
            }
        } 
    }
}
