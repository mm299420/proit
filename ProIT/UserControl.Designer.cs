using System.ComponentModel;

namespace ProIT
{
    partial class UserControl
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
            this.txtMitarbName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxUserName = new System.Windows.Forms.ComboBox();
            this.cBoxAbteilung = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswdGen = new System.Windows.Forms.TextBox();
            this.btnInsertPWD = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMitarbName
            // 
            this.txtMitarbName.Location = new System.Drawing.Point(58, 174);
            this.txtMitarbName.Name = "txtMitarbName";
            this.txtMitarbName.Size = new System.Drawing.Size(234, 20);
            this.txtMitarbName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(58, 148);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 20);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.Text = "Password Verify";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(212, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 114);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(386, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 252);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(58, 225);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(71, 114);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(135, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 114);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxUserName
            // 
            this.cBoxUserName.FormattingEnabled = true;
            this.cBoxUserName.Location = new System.Drawing.Point(58, 96);
            this.cBoxUserName.Name = "cBoxUserName";
            this.cBoxUserName.Size = new System.Drawing.Size(234, 21);
            this.cBoxUserName.TabIndex = 12;
            // 
            // cBoxAbteilung
            // 
            this.cBoxAbteilung.FormattingEnabled = true;
            this.cBoxAbteilung.Location = new System.Drawing.Point(58, 48);
            this.cBoxAbteilung.Name = "cBoxAbteilung";
            this.cBoxAbteilung.Size = new System.Drawing.Size(234, 21);
            this.cBoxAbteilung.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(58, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Abteilung";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPasswdGen);
            this.groupBox1.Controls.Add(this.btnInsertPWD);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(386, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 89);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 21);
            this.label3.TabIndex = 22;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPasswdGen
            // 
            this.txtPasswdGen.Location = new System.Drawing.Point(6, 40);
            this.txtPasswdGen.Name = "txtPasswdGen";
            this.txtPasswdGen.Size = new System.Drawing.Size(326, 20);
            this.txtPasswdGen.TabIndex = 21;
            // 
            // btnInsertPWD
            // 
            this.btnInsertPWD.Location = new System.Drawing.Point(172, 60);
            this.btnInsertPWD.Name = "btnInsertPWD";
            this.btnInsertPWD.Size = new System.Drawing.Size(160, 21);
            this.btnInsertPWD.TabIndex = 20;
            this.btnInsertPWD.Text = "Update";
            this.btnInsertPWD.UseVisualStyleBackColor = true;
            this.btnInsertPWD.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(6, 60);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(160, 21);
            this.btnGenerate.TabIndex = 19;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(743, 12);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 152);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 15;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(178, 148);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(114, 20);
            this.txtPassword2.TabIndex = 17;
            this.txtPassword2.Text = "Password Verify";
            this.txtPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword2.Visible = false;
            this.txtPassword2.Click += new System.EventHandler(this.txtPassword2_Click);
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cBoxAbteilung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMitarbName);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "UserControl";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPassword2;

        private System.Windows.Forms.TrackBar trackBar1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasswdGen;
        private System.Windows.Forms.Button btnInsertPWD;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.ComboBox cBoxUserName;
        private System.Windows.Forms.ComboBox cBoxAbteilung;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button btnCreate;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.TextBox txtMitarbName;
        private System.Windows.Forms.TextBox txtPassword;

        #endregion
    }
}