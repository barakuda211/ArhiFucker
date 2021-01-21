
namespace ArhiFucker
{
    partial class CacheForm
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
            this.textBox_cache_time = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.textBox_miss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_hit = new System.Windows.Forms.TextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.textBox_res = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_cache_time
            // 
            this.textBox_cache_time.Location = new System.Drawing.Point(249, 16);
            this.textBox_cache_time.Name = "textBox_cache_time";
            this.textBox_cache_time.Size = new System.Drawing.Size(204, 20);
            this.textBox_cache_time.TabIndex = 0;
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(249, 53);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(204, 20);
            this.textBox_time.TabIndex = 1;
            // 
            // textBox_miss
            // 
            this.textBox_miss.Location = new System.Drawing.Point(130, 91);
            this.textBox_miss.Name = "textBox_miss";
            this.textBox_miss.Size = new System.Drawing.Size(50, 20);
            this.textBox_miss.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Среднее время доступа к кэшу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Среднее время доступа к основной памяти:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Доля кэш-промахов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "или доля кэш-попаданий:";
            // 
            // textBox_hit
            // 
            this.textBox_hit.Location = new System.Drawing.Point(180, 117);
            this.textBox_hit.Name = "textBox_hit";
            this.textBox_hit.Size = new System.Drawing.Size(50, 20);
            this.textBox_hit.TabIndex = 6;
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(335, 158);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(141, 22);
            this.button_solve.TabIndex = 8;
            this.button_solve.Text = "Решить";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // textBox_res
            // 
            this.textBox_res.Location = new System.Drawing.Point(74, 158);
            this.textBox_res.Name = "textBox_res";
            this.textBox_res.Size = new System.Drawing.Size(204, 20);
            this.textBox_res.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат:";
            // 
            // CacheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 191);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_res);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_hit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_miss);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.textBox_cache_time);
            this.Name = "CacheForm";
            this.Text = "Кэш попадания";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_cache_time;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.TextBox textBox_miss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_hit;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.TextBox textBox_res;
        private System.Windows.Forms.Label label5;
    }
}