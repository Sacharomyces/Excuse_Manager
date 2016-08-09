using System;

namespace Zadanie_str_431
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.excuseTextBox = new System.Windows.Forms.TextBox();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.excuseLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.useLabel = new System.Windows.Forms.Label();
            this.fileDateLabel = new System.Windows.Forms.Label();
            this.showDateLabel = new System.Windows.Forms.Label();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.folderButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.excuseTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultsTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.excuseLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.useLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fileDateLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.showDateLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lastUsed, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 167);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // excuseTextBox
            // 
            this.excuseTextBox.Location = new System.Drawing.Point(123, 8);
            this.excuseTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.excuseTextBox.Name = "excuseTextBox";
            this.excuseTextBox.Size = new System.Drawing.Size(406, 26);
            this.excuseTextBox.TabIndex = 0;
            this.excuseTextBox.TextChanged += new System.EventHandler(this.excuseTextBox_TextChanged);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(123, 49);
            this.resultsTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(406, 26);
            this.resultsTextBox.TabIndex = 1;
            this.resultsTextBox.TextChanged += new System.EventHandler(this.resultsTextBox_TextChanged);
            // 
            // excuseLabel
            // 
            this.excuseLabel.AutoSize = true;
            this.excuseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excuseLabel.Location = new System.Drawing.Point(3, 0);
            this.excuseLabel.Name = "excuseLabel";
            this.excuseLabel.Size = new System.Drawing.Size(114, 41);
            this.excuseLabel.TabIndex = 4;
            this.excuseLabel.Text = "Excuse";
            this.excuseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLabel.Location = new System.Drawing.Point(3, 41);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(114, 41);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Results";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // useLabel
            // 
            this.useLabel.AutoSize = true;
            this.useLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useLabel.Location = new System.Drawing.Point(3, 82);
            this.useLabel.Name = "useLabel";
            this.useLabel.Size = new System.Drawing.Size(114, 41);
            this.useLabel.TabIndex = 6;
            this.useLabel.Text = "Last Used";
            this.useLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileDateLabel
            // 
            this.fileDateLabel.AutoSize = true;
            this.fileDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileDateLabel.Location = new System.Drawing.Point(3, 123);
            this.fileDateLabel.Name = "fileDateLabel";
            this.fileDateLabel.Size = new System.Drawing.Size(114, 44);
            this.fileDateLabel.TabIndex = 7;
            this.fileDateLabel.Text = "Last Saved";
            this.fileDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showDateLabel
            // 
            this.showDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showDateLabel.Location = new System.Drawing.Point(123, 129);
            this.showDateLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.showDateLabel.Name = "showDateLabel";
            this.showDateLabel.Size = new System.Drawing.Size(409, 32);
            this.showDateLabel.TabIndex = 8;
            // 
            // lastUsed
            // 
            this.lastUsed.CustomFormat = " ";
            this.lastUsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastUsed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastUsed.Location = new System.Drawing.Point(123, 90);
            this.lastUsed.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(409, 26);
            this.lastUsed.TabIndex = 9;
            this.lastUsed.Value = new System.DateTime(2016, 8, 9, 0, 0, 0, 0);
            this.lastUsed.ValueChanged += new System.EventHandler(this.lastUsed_ValueChanged);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(22, 184);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(97, 28);
            this.folderButton.TabIndex = 1;
            this.folderButton.Text = "Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // openButton
            // 
            this.openButton.Enabled = false;
            this.openButton.Location = new System.Drawing.Point(144, 184);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(97, 28);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(266, 184);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 28);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Enabled = false;
            this.randomButton.Location = new System.Drawing.Point(388, 184);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(97, 28);
            this.randomButton.TabIndex = 4;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 235);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox excuseTextBox;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Label excuseLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label useLabel;
        private System.Windows.Forms.Label fileDateLabel;
        private System.Windows.Forms.Label showDateLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

