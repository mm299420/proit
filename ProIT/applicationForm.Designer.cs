using System.ComponentModel;

namespace ProIT
{
    partial class applicationForm
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
            this.btnApplication = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApplication
            // 
            this.btnApplication.Location = new System.Drawing.Point(12, 12);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(436, 81);
            this.btnApplication.TabIndex = 0;
            this.btnApplication.Text = "New Application";
            this.btnApplication.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(12, 99);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(436, 81);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Upload Result";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // applicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 193);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnApplication);
            this.Name = "applicationForm";
            this.Text = "applicationForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Button btnResult;

        #endregion
    }
}