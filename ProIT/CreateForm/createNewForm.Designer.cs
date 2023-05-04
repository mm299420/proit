using System.ComponentModel;

namespace ProIT.CreateForm
{
    partial class createNewForm
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
            this.checkChangeTarget = new System.Windows.Forms.CheckBox();
            this.cBoxFieldType = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackWeighting = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWeighting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkChangeTarget
            // 
            this.checkChangeTarget.Location = new System.Drawing.Point(12, 331);
            this.checkChangeTarget.Name = "checkChangeTarget";
            this.checkChangeTarget.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkChangeTarget.Size = new System.Drawing.Size(97, 45);
            this.checkChangeTarget.TabIndex = 0;
            this.checkChangeTarget.Text = "checkBox1";
            this.checkChangeTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkChangeTarget.UseVisualStyleBackColor = true;
            this.checkChangeTarget.CheckedChanged += new System.EventHandler(this.checkChangeTarget_CheckedChanged);
            // 
            // cBoxFieldType
            // 
            this.cBoxFieldType.FormattingEnabled = true;
            this.cBoxFieldType.Location = new System.Drawing.Point(467, 148);
            this.cBoxFieldType.Name = "cBoxFieldType";
            this.cBoxFieldType.Size = new System.Drawing.Size(218, 21);
            this.cBoxFieldType.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(467, 252);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(218, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // trackWeighting
            // 
            this.trackWeighting.Enabled = false;
            this.trackWeighting.Location = new System.Drawing.Point(115, 331);
            this.trackWeighting.Name = "trackWeighting";
            this.trackWeighting.Size = new System.Drawing.Size(206, 45);
            this.trackWeighting.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(309, 264);
            this.listBox1.TabIndex = 5;
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(329, 238);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(77, 138);
            this.btnBearbeiten.TabIndex = 6;
            this.btnBearbeiten.Text = "bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(467, 175);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(218, 20);
            this.txtFieldName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(467, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(467, 201);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(218, 45);
            this.trackBar2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(428, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 395);
            this.panel1.TabIndex = 10;
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(714, 238);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(77, 138);
            this.btnHinzufügen.TabIndex = 11;
            this.btnHinzufügen.Text = "hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            // 
            // createNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 393);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackWeighting);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cBoxFieldType);
            this.Controls.Add(this.checkChangeTarget);
            this.Name = "createNewForm";
            this.Text = "createNewForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWeighting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHinzufügen;

        public System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;

        private System.Windows.Forms.Button btnBearbeiten;

        private System.Windows.Forms.CheckBox checkChangeTarget;
        public System.Windows.Forms.ComboBox cBoxFieldType;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar trackWeighting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}