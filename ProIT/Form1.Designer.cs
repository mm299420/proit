namespace ProIT
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
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(12, 61);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(169, 20);
            this.txtPasswd.TabIndex = 0;
            this.txtPasswd.Text = "Password";
            this.txtPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswd.Click += new System.EventHandler(this.txtPasswd_TextChanged);
            this.txtPasswd.TextChanged += new System.EventHandler(this.txtPasswd_TextChanged);
            this.txtPasswd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(12, 35);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(169, 20);
            this.txtUname.TabIndex = 1;
            this.txtUname.Text = "Username";
            this.txtUname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUname.Click += new System.EventHandler(this.txtUname_TextChanged);
            this.txtUname.TextChanged += new System.EventHandler(this.txtUname_TextChanged);
            this.txtUname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 94);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.txtPasswd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}