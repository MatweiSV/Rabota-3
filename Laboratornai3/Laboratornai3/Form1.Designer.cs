
namespace Laboratornai3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.znak = new System.Windows.Forms.Label();
            this.Reshenie = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Ymnojit = new System.Windows.Forms.Button();
            this.Delit = new System.Windows.Forms.Button();
            this.POW = new System.Windows.Forms.Button();
            this.Procent = new System.Windows.Forms.Button();
            this.Itog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(97, 134);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 23);
            this.TextBox1.TabIndex = 0;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(346, 134);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 23);
            this.TextBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Число 2";
            // 
            // znak
            // 
            this.znak.AutoSize = true;
            this.znak.Location = new System.Drawing.Point(249, 137);
            this.znak.Name = "znak";
            this.znak.Size = new System.Drawing.Size(0, 15);
            this.znak.TabIndex = 4;
            // 
            // Reshenie
            // 
            this.Reshenie.AutoSize = true;
            this.Reshenie.Location = new System.Drawing.Point(503, 137);
            this.Reshenie.Name = "Reshenie";
            this.Reshenie.Size = new System.Drawing.Size(38, 15);
            this.Reshenie.TabIndex = 5;
            this.Reshenie.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Выберете операцию";
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(20, 12);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(38, 23);
            this.Plus.TabIndex = 7;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(80, 12);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(37, 23);
            this.Minus.TabIndex = 8;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Ymnojit
            // 
            this.Ymnojit.Location = new System.Drawing.Point(134, 12);
            this.Ymnojit.Name = "Ymnojit";
            this.Ymnojit.Size = new System.Drawing.Size(34, 23);
            this.Ymnojit.TabIndex = 9;
            this.Ymnojit.Text = "*";
            this.Ymnojit.UseVisualStyleBackColor = true;
            this.Ymnojit.Click += new System.EventHandler(this.Ymnojit_Click);
            // 
            // Delit
            // 
            this.Delit.Location = new System.Drawing.Point(183, 12);
            this.Delit.Name = "Delit";
            this.Delit.Size = new System.Drawing.Size(38, 23);
            this.Delit.TabIndex = 10;
            this.Delit.Text = "/";
            this.Delit.UseVisualStyleBackColor = true;
            this.Delit.Click += new System.EventHandler(this.Delit_Click);
            // 
            // POW
            // 
            this.POW.Location = new System.Drawing.Point(239, 12);
            this.POW.Name = "POW";
            this.POW.Size = new System.Drawing.Size(44, 23);
            this.POW.TabIndex = 11;
            this.POW.Text = "POW";
            this.POW.UseVisualStyleBackColor = true;
            this.POW.Click += new System.EventHandler(this.POW_Click);
            // 
            // Procent
            // 
            this.Procent.Location = new System.Drawing.Point(302, 12);
            this.Procent.Name = "Procent";
            this.Procent.Size = new System.Drawing.Size(38, 23);
            this.Procent.TabIndex = 12;
            this.Procent.Text = "%";
            this.Procent.UseVisualStyleBackColor = true;
            this.Procent.Click += new System.EventHandler(this.Procent_Click);
            // 
            // Itog
            // 
            this.Itog.Location = new System.Drawing.Point(593, 264);
            this.Itog.Name = "Itog";
            this.Itog.Size = new System.Drawing.Size(75, 23);
            this.Itog.TabIndex = 13;
            this.Itog.Text = "=";
            this.Itog.UseVisualStyleBackColor = true;
            this.Itog.Click += new System.EventHandler(this.Itog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.Procent);
            this.groupBox1.Controls.Add(this.POW);
            this.groupBox1.Controls.Add(this.Delit);
            this.groupBox1.Controls.Add(this.Ymnojit);
            this.groupBox1.Controls.Add(this.Minus);
            this.groupBox1.Controls.Add(this.Plus);
            this.groupBox1.Location = new System.Drawing.Point(57, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 44);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Itog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Reshenie);
            this.Controls.Add(this.znak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox chislo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label znak;
        private System.Windows.Forms.Label Reshenie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Ymnojit;
        private System.Windows.Forms.Button Delit;
        private System.Windows.Forms.Button POW;
        private System.Windows.Forms.Button Procent;
        private System.Windows.Forms.Button Itog;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

