
namespace ArhiFucker
{
    partial class FormLittle
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
            this.textBox_sizebit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_size = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_res = new System.Windows.Forms.TextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_word = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Размер ячейки(бит):";
            // 
            // textBox_sizebit
            // 
            this.textBox_sizebit.Location = new System.Drawing.Point(141, 6);
            this.textBox_sizebit.Name = "textBox_sizebit";
            this.textBox_sizebit.Size = new System.Drawing.Size(204, 20);
            this.textBox_sizebit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Размер слова(ячейки):";
            // 
            // textBox_size
            // 
            this.textBox_size.Location = new System.Drawing.Point(141, 32);
            this.textBox_size.Name = "textBox_size";
            this.textBox_size.Size = new System.Drawing.Size(204, 20);
            this.textBox_size.TabIndex = 6;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(141, 81);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(122, 17);
            this.checkBox.TabIndex = 8;
            this.checkBox.Text = "Обратный порядок";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Результат:";
            // 
            // textBox_res
            // 
            this.textBox_res.Location = new System.Drawing.Point(79, 110);
            this.textBox_res.Name = "textBox_res";
            this.textBox_res.Size = new System.Drawing.Size(349, 20);
            this.textBox_res.TabIndex = 12;
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(451, 108);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(141, 22);
            this.button_solve.TabIndex = 11;
            this.button_solve.Text = "Решить";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Кодируемое слово:";
            // 
            // textBox_word
            // 
            this.textBox_word.Location = new System.Drawing.Point(141, 55);
            this.textBox_word.Name = "textBox_word";
            this.textBox_word.Size = new System.Drawing.Size(204, 20);
            this.textBox_word.TabIndex = 14;
            // 
            // FormLittle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 183);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_word);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_res);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sizebit);
            this.Name = "FormLittle";
            this.Text = "Прямой, обратный порядок байтов";
            this.Load += new System.EventHandler(this.FormLittle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_sizebit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_res;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_word;
    }
}