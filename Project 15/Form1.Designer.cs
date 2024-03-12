
namespace Project_Bluebird
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radioeconomy = new System.Windows.Forms.RadioButton();
            this.Radiobusiness = new System.Windows.Forms.RadioButton();
            this.Radiofirst = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbox = new System.Windows.Forms.ComboBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Listbox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(428, 37);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(153, 22);
            this.txtNaam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radioeconomy);
            this.groupBox1.Controls.Add(this.Radiobusiness);
            this.groupBox1.Controls.Add(this.Radiofirst);
            this.groupBox1.Location = new System.Drawing.Point(367, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class";
            // 
            // Radioeconomy
            // 
            this.Radioeconomy.AutoSize = true;
            this.Radioeconomy.Location = new System.Drawing.Point(6, 77);
            this.Radioeconomy.Name = "Radioeconomy";
            this.Radioeconomy.Size = new System.Drawing.Size(123, 21);
            this.Radioeconomy.TabIndex = 2;
            this.Radioeconomy.TabStop = true;
            this.Radioeconomy.Text = "Economy class";
            this.Radioeconomy.UseVisualStyleBackColor = true;
            this.Radioeconomy.CheckedChanged += new System.EventHandler(this.RBClass_CheckedChanged);
            // 
            // Radiobusiness
            // 
            this.Radiobusiness.AutoSize = true;
            this.Radiobusiness.Location = new System.Drawing.Point(6, 48);
            this.Radiobusiness.Name = "Radiobusiness";
            this.Radiobusiness.Size = new System.Drawing.Size(122, 21);
            this.Radiobusiness.TabIndex = 1;
            this.Radiobusiness.TabStop = true;
            this.Radiobusiness.Text = "Business class";
            this.Radiobusiness.UseVisualStyleBackColor = true;
            this.Radiobusiness.CheckedChanged += new System.EventHandler(this.RBClass_CheckedChanged);
            // 
            // Radiofirst
            // 
            this.Radiofirst.AutoSize = true;
            this.Radiofirst.Location = new System.Drawing.Point(6, 21);
            this.Radiofirst.Name = "Radiofirst";
            this.Radiofirst.Size = new System.Drawing.Size(92, 21);
            this.Radiofirst.TabIndex = 0;
            this.Radiofirst.TabStop = true;
            this.Radiofirst.Text = "First class";
            this.Radiofirst.UseVisualStyleBackColor = true;
            this.Radiofirst.CheckedChanged += new System.EventHandler(this.RBClass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stoelnummer";
            // 
            // Cbox
            // 
            this.Cbox.FormattingEnabled = true;
            this.Cbox.Location = new System.Drawing.Point(470, 232);
            this.Cbox.Name = "Cbox";
            this.Cbox.Size = new System.Drawing.Size(121, 24);
            this.Cbox.TabIndex = 4;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(293, 283);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(108, 55);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Stoel toevoegen";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.BTstoelToevoegen_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(407, 282);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(106, 55);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "Stoel vrijgeven";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.BTstoelVrijgeven_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(519, 282);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(103, 56);
            this.Button3.TabIndex = 7;
            this.Button3.Text = "Programma afsluiten";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.BTprogrammaAfsluiten_Click);
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            this.Listbox.ItemHeight = 16;
            this.Listbox.Location = new System.Drawing.Point(23, 37);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(216, 292);
            this.Listbox.TabIndex = 8;
            this.Listbox.SelectedIndexChanged += new System.EventHandler(this.LBstoelenLijst_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 379);
            this.Controls.Add(this.Listbox);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Cbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radiofirst;
        private System.Windows.Forms.RadioButton Radioeconomy;
        private System.Windows.Forms.RadioButton Radiobusiness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbox;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.ListBox Listbox;
    }
}

