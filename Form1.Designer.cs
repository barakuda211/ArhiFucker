
namespace ArhiFucker
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_cache = new System.Windows.Forms.Button();
            this.button_toreal = new System.Windows.Forms.Button();
            this.button_mips = new System.Windows.Forms.Button();
            this.button_littlebig = new System.Windows.Forms.Button();
            this.button_hdd = new System.Windows.Forms.Button();
            this.button_tasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cache
            // 
            this.button_cache.Location = new System.Drawing.Point(13, 13);
            this.button_cache.Name = "button_cache";
            this.button_cache.Size = new System.Drawing.Size(211, 31);
            this.button_cache.TabIndex = 0;
            this.button_cache.Text = "Скорость доступа к кэшу";
            this.button_cache.UseVisualStyleBackColor = true;
            this.button_cache.Click += new System.EventHandler(this.button_cache_Click);
            // 
            // button_toreal
            // 
            this.button_toreal.Location = new System.Drawing.Point(12, 87);
            this.button_toreal.Name = "button_toreal";
            this.button_toreal.Size = new System.Drawing.Size(211, 31);
            this.button_toreal.TabIndex = 1;
            this.button_toreal.Text = "Вещественное двоичное число";
            this.button_toreal.UseVisualStyleBackColor = true;
            this.button_toreal.Click += new System.EventHandler(this.button_toreal_Click);
            // 
            // button_mips
            // 
            this.button_mips.Location = new System.Drawing.Point(12, 201);
            this.button_mips.Name = "button_mips";
            this.button_mips.Size = new System.Drawing.Size(211, 31);
            this.button_mips.TabIndex = 2;
            this.button_mips.Text = "MIPS в двоичное число";
            this.button_mips.UseVisualStyleBackColor = true;
            // 
            // button_littlebig
            // 
            this.button_littlebig.Location = new System.Drawing.Point(13, 50);
            this.button_littlebig.Name = "button_littlebig";
            this.button_littlebig.Size = new System.Drawing.Size(211, 31);
            this.button_littlebig.TabIndex = 3;
            this.button_littlebig.Text = "Прямое, обратное кодирование";
            this.button_littlebig.UseVisualStyleBackColor = true;
            this.button_littlebig.Click += new System.EventHandler(this.button_littlebig_Click);
            // 
            // button_hdd
            // 
            this.button_hdd.Location = new System.Drawing.Point(13, 124);
            this.button_hdd.Name = "button_hdd";
            this.button_hdd.Size = new System.Drawing.Size(211, 31);
            this.button_hdd.TabIndex = 4;
            this.button_hdd.Text = "Шина жесткого диска";
            this.button_hdd.UseVisualStyleBackColor = true;
            this.button_hdd.Click += new System.EventHandler(this.button_hdd_Click);
            // 
            // button_tasks
            // 
            this.button_tasks.Location = new System.Drawing.Point(12, 164);
            this.button_tasks.Name = "button_tasks";
            this.button_tasks.Size = new System.Drawing.Size(211, 31);
            this.button_tasks.TabIndex = 5;
            this.button_tasks.Text = "Задания в пакетном режиме";
            this.button_tasks.UseVisualStyleBackColor = true;
            this.button_tasks.Click += new System.EventHandler(this.button_tasks_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 340);
            this.Controls.Add(this.button_tasks);
            this.Controls.Add(this.button_hdd);
            this.Controls.Add(this.button_littlebig);
            this.Controls.Add(this.button_mips);
            this.Controls.Add(this.button_toreal);
            this.Controls.Add(this.button_cache);
            this.Name = "MainForm";
            this.Text = "ArhiFucker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cache;
        private System.Windows.Forms.Button button_toreal;
        private System.Windows.Forms.Button button_mips;
        private System.Windows.Forms.Button button_littlebig;
        private System.Windows.Forms.Button button_hdd;
        private System.Windows.Forms.Button button_tasks;
    }
}

