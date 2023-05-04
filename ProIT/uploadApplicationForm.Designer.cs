using System.ComponentModel;

namespace ProIT
{
    partial class uploadApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxApplication = new System.Windows.Forms.ComboBox();
            this.cBoxApplicant = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(12, 186);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(181, 41);
            this.btnAnalyse.TabIndex = 3;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxApplication
            // 
            this.cBoxApplication.FormattingEnabled = true;
            this.cBoxApplication.Location = new System.Drawing.Point(12, 45);
            this.cBoxApplication.Name = "cBoxApplication";
            this.cBoxApplication.Size = new System.Drawing.Size(181, 21);
            this.cBoxApplication.TabIndex = 7;
            // 
            // cBoxApplicant
            // 
            this.cBoxApplicant.FormattingEnabled = true;
            this.cBoxApplicant.Location = new System.Drawing.Point(12, 99);
            this.cBoxApplicant.Name = "cBoxApplicant";
            this.cBoxApplicant.Size = new System.Drawing.Size(181, 21);
            this.cBoxApplicant.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Applicant";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(366, 15);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(202, 258);
            this.txtResult.TabIndex = 10;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(199, 9);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(161, 264);
            this.listBoxFiles.TabIndex = 11;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // uploadApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 286);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cBoxApplicant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxApplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.button1);
            this.Name = "uploadApplicationForm";
            this.Text = "uploadApplicationForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listBoxFiles;

        private System.Windows.Forms.TextBox txtResult;

        private System.Windows.Forms.ComboBox cBoxApplication;
        private System.Windows.Forms.ComboBox cBoxApplicant;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnAnalyse;

        private System.Windows.Forms.Button btnDelete;
        
        private System.Windows.Forms.Button button1;

        #endregion
    }
}