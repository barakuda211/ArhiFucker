
namespace ArhiFucker
{
    partial class HardDiskForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.textBox_res1 = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_res2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Размер шины:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Габариты :";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(84, 12);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(63, 20);
            this.textBox_a.TabIndex = 27;
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(360, 10);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(141, 22);
            this.button_solve.TabIndex = 33;
            this.button_solve.Text = "Решить";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // textBox_res1
            // 
            this.textBox_res1.Location = new System.Drawing.Point(98, 48);
            this.textBox_res1.Name = "textBox_res1";
            this.textBox_res1.Size = new System.Drawing.Size(349, 20);
            this.textBox_res1.TabIndex = 34;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(173, 12);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(63, 20);
            this.textBox_b.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Х";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Х";
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(266, 12);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(63, 20);
            this.textBox_c.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Размер диска:";
            // 
            // textBox_res2
            // 
            this.textBox_res2.Location = new System.Drawing.Point(98, 74);
            this.textBox_res2.Name = "textBox_res2";
            this.textBox_res2.Size = new System.Drawing.Size(349, 20);
            this.textBox_res2.TabIndex = 41;
            // 
            // HardDiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 110);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_res2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_res1);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_a);
            this.Name = "HardDiskForm";
            this.Text = "HardDiskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.TextBox textBox_res1;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_res2;
    }
}