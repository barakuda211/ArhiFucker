
namespace ArhiFucker
{
    partial class RealBinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_word = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_real = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_int = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_res = new System.Windows.Forms.TextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Кодируемое слово:";
            // 
            // textBox_word
            // 
            this.textBox_word.Location = new System.Drawing.Point(141, 55);
            this.textBox_word.Name = "textBox_word";
            this.textBox_word.Size = new System.Drawing.Size(204, 20);
            this.textBox_word.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Бит на мантису";
            // 
            // textBox_real
            // 
            this.textBox_real.Location = new System.Drawing.Point(141, 32);
            this.textBox_real.Name = "textBox_real";
            this.textBox_real.Size = new System.Drawing.Size(204, 20);
            this.textBox_real.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Бит на целую часть";
            // 
            // textBox_int
            // 
            this.textBox_int.Location = new System.Drawing.Point(141, 6);
            this.textBox_int.Name = "textBox_int";
            this.textBox_int.Size = new System.Drawing.Size(204, 20);
            this.textBox_int.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Результат:";
            // 
            // textBox_res
            // 
            this.textBox_res.Location = new System.Drawing.Point(75, 93);
            this.textBox_res.Name = "textBox_res";
            this.textBox_res.Size = new System.Drawing.Size(349, 20);
            this.textBox_res.TabIndex = 25;
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(447, 91);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(141, 22);
            this.button_solve.TabIndex = 24;
            this.button_solve.Text = "Решить";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // RealBinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 128);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_res);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_word);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_real);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_int);
            this.Name = "RealBinForm";
            this.Text = "RealBinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_word;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_real;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_int;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_res;
        private System.Windows.Forms.Button button_solve;
    }
}