using System.ComponentModel;

namespace ProIT
{
    partial class createApplicationForm
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
            this.btnForm = new System.Windows.Forms.Button();
            this.btnField = new System.Windows.Forms.Button();
            this.btnFormEdit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblAbt = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cBoxProcess = new System.Windows.Forms.ComboBox();
            this.cBoxAbt = new System.Windows.Forms.ComboBox();
            this.lblForm = new System.Windows.Forms.Label();
            this.cBoxForm = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.formGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.formGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnForm
            // 
            this.btnForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnForm.Location = new System.Drawing.Point(302, 12);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(158, 37);
            this.btnForm.TabIndex = 0;
            this.btnForm.Text = "Formular";
            this.btnForm.UseVisualStyleBackColor = false;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnField
            // 
            this.btnField.Location = new System.Drawing.Point(630, 12);
            this.btnField.Name = "btnField";
            this.btnField.Size = new System.Drawing.Size(246, 37);
            this.btnField.TabIndex = 1;
            this.btnField.Text = "Felder";
            this.btnField.UseVisualStyleBackColor = true;
            this.btnField.Click += new System.EventHandler(this.btnField_Click);
            // 
            // btnFormEdit
            // 
            this.btnFormEdit.Enabled = false;
            this.btnFormEdit.Location = new System.Drawing.Point(466, 12);
            this.btnFormEdit.Name = "btnFormEdit";
            this.btnFormEdit.Size = new System.Drawing.Size(158, 37);
            this.btnFormEdit.TabIndex = 2;
            this.btnFormEdit.Text = "Formular Ausfüllen";
            this.btnFormEdit.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(304, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 381);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Erstelle ein neues Formular";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 514);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(284, 37);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Neu Erstellen";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // lblProcess
            // 
            this.lblProcess.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProcess.Location = new System.Drawing.Point(12, 148);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(284, 19);
            this.lblProcess.TabIndex = 15;
            this.lblProcess.Text = "Bewerbungsprozesse";
            this.lblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbt
            // 
            this.lblAbt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAbt.Location = new System.Drawing.Point(12, 102);
            this.lblAbt.Name = "lblAbt";
            this.lblAbt.Size = new System.Drawing.Size(284, 19);
            this.lblAbt.TabIndex = 14;
            this.lblAbt.Text = "Abteilung";
            this.lblAbt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(284, 37);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Form hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cBoxProcess
            // 
            this.cBoxProcess.Enabled = false;
            this.cBoxProcess.FormattingEnabled = true;
            this.cBoxProcess.Location = new System.Drawing.Point(12, 170);
            this.cBoxProcess.Name = "cBoxProcess";
            this.cBoxProcess.Size = new System.Drawing.Size(284, 21);
            this.cBoxProcess.TabIndex = 12;
            this.cBoxProcess.Text = "Process";
            // 
            // cBoxAbt
            // 
            this.cBoxAbt.FormattingEnabled = true;
            this.cBoxAbt.Location = new System.Drawing.Point(14, 124);
            this.cBoxAbt.Name = "cBoxAbt";
            this.cBoxAbt.Size = new System.Drawing.Size(284, 21);
            this.cBoxAbt.TabIndex = 11;
            this.cBoxAbt.Text = "Abteilung";
            this.cBoxAbt.SelectedIndexChanged += new System.EventHandler(this.cBoxAbt_SelectedIndexChanged);
            // 
            // lblForm
            // 
            this.lblForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblForm.Location = new System.Drawing.Point(12, 56);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(284, 19);
            this.lblForm.TabIndex = 17;
            this.lblForm.Text = "Formular Art";
            this.lblForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxForm
            // 
            this.cBoxForm.FormattingEnabled = true;
            this.cBoxForm.Location = new System.Drawing.Point(14, 78);
            this.cBoxForm.Name = "cBoxForm";
            this.cBoxForm.Size = new System.Drawing.Size(284, 21);
            this.cBoxForm.TabIndex = 16;
            this.cBoxForm.Text = "Formular";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(630, 55);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(246, 381);
            this.listBox2.TabIndex = 18;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(302, 514);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(284, 37);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Bearbeiten";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(592, 514);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(284, 37);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // formGroupBox
            // 
            this.formGroupBox.Controls.Add(this.label2);
            this.formGroupBox.Controls.Add(this.txtFieldName);
            this.formGroupBox.Enabled = false;
            this.formGroupBox.Location = new System.Drawing.Point(12, 274);
            this.formGroupBox.Name = "formGroupBox";
            this.formGroupBox.Size = new System.Drawing.Size(284, 94);
            this.formGroupBox.TabIndex = 21;
            this.formGroupBox.TabStop = false;
            this.formGroupBox.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Bewerbungsprozesse";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(0, 52);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(284, 20);
            this.txtFieldName.TabIndex = 24;
            // 
            // createApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 563);
            this.Controls.Add(this.formGroupBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.cBoxForm);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.lblAbt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cBoxProcess);
            this.Controls.Add(this.cBoxAbt);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnFormEdit);
            this.Controls.Add(this.btnField);
            this.Controls.Add(this.btnForm);
            this.Name = "createApplicationForm";
            this.Text = "Formulare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.createApplicationForm_FormClosing);
            this.Load += new System.EventHandler(this.createApplicationForm_Load);
            this.formGroupBox.ResumeLayout(false);
            this.formGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox formGroupBox;

        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.ListBox listBox2;

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.ComboBox cBoxForm;

        private System.Windows.Forms.ComboBox cBoxAbt;
        private System.Windows.Forms.ComboBox cBoxProcess;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAbt;
        private System.Windows.Forms.Label lblProcess;

        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Button btnField;
        private System.Windows.Forms.Button btnFormEdit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}