using System.ComponentModel;

namespace ProIT.CreateForm
{
    partial class createNewField
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
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cBoxFieldType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackWeighting = new System.Windows.Forms.TrackBar();
            this.checkChangeTarget = new System.Windows.Forms.CheckBox();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWeighting)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(533, 199);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(218, 45);
            this.trackBar2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(533, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(533, 173);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(218, 20);
            this.txtFieldName.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(533, 250);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(218, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // cBoxFieldType
            // 
            this.cBoxFieldType.FormattingEnabled = true;
            this.cBoxFieldType.Location = new System.Drawing.Point(533, 146);
            this.cBoxFieldType.Name = "cBoxFieldType";
            this.cBoxFieldType.Size = new System.Drawing.Size(218, 21);
            this.cBoxFieldType.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(428, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 395);
            this.panel1.TabIndex = 25;
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(329, 238);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(77, 138);
            this.btnBearbeiten.TabIndex = 24;
            this.btnBearbeiten.Text = "bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(309, 264);
            this.listBox1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackWeighting
            // 
            this.trackWeighting.Enabled = false;
            this.trackWeighting.Location = new System.Drawing.Point(115, 331);
            this.trackWeighting.Name = "trackWeighting";
            this.trackWeighting.Size = new System.Drawing.Size(206, 45);
            this.trackWeighting.TabIndex = 21;
            // 
            // checkChangeTarget
            // 
            this.checkChangeTarget.Location = new System.Drawing.Point(12, 331);
            this.checkChangeTarget.Name = "checkChangeTarget";
            this.checkChangeTarget.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkChangeTarget.Size = new System.Drawing.Size(97, 45);
            this.checkChangeTarget.TabIndex = 20;
            this.checkChangeTarget.Text = "checkBox1";
            this.checkChangeTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkChangeTarget.UseVisualStyleBackColor = true;
            this.checkChangeTarget.CheckedChanged += new System.EventHandler(this.checkChangeTarget_CheckedChanged);
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(805, 247);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(77, 138);
            this.btnHinzufügen.TabIndex = 26;
            this.btnHinzufügen.Text = "hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            // 
            // createNewField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 397);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackWeighting);
            this.Controls.Add(this.checkChangeTarget);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cBoxFieldType);
            this.Name = "createNewField";
            this.Text = "createNewField";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWeighting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnHinzufügen;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.TrackBar trackWeighting;
        private System.Windows.Forms.CheckBox checkChangeTarget;

        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.ComboBox cBoxFieldType;

        #endregion
    }
}