namespace WindowsForms_GraphicsFunction
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.демонстрацияСдвигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.демонстрацияПоворотаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.демонстрацияСжатияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.демонстрацияСдвигаИПоворотаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.демонстрацияПоворотаИСдвигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.графикToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьToolStripMenuItem,
            this.демонстрацияСдвигаToolStripMenuItem,
            this.демонстрацияПоворотаToolStripMenuItem,
            this.демонстрацияСжатияToolStripMenuItem,
            this.демонстрацияСдвигаИПоворотаToolStripMenuItem,
            this.демонстрацияПоворотаИСдвигаToolStripMenuItem});
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            this.графикToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.графикToolStripMenuItem.Text = "График";
            // 
            // построитьToolStripMenuItem
            // 
            this.построитьToolStripMenuItem.Name = "построитьToolStripMenuItem";
            this.построитьToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.построитьToolStripMenuItem.Text = "построить";
            this.построитьToolStripMenuItem.Click += new System.EventHandler(this.построитьToolStripMenuItem_Click);
            // 
            // демонстрацияСдвигаToolStripMenuItem
            // 
            this.демонстрацияСдвигаToolStripMenuItem.Enabled = false;
            this.демонстрацияСдвигаToolStripMenuItem.Name = "демонстрацияСдвигаToolStripMenuItem";
            this.демонстрацияСдвигаToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.демонстрацияСдвигаToolStripMenuItem.Text = "демонстрация сдвига";
            this.демонстрацияСдвигаToolStripMenuItem.Click += new System.EventHandler(this.демонстрацияСдвигаToolStripMenuItem_Click);
            // 
            // демонстрацияПоворотаToolStripMenuItem
            // 
            this.демонстрацияПоворотаToolStripMenuItem.Enabled = false;
            this.демонстрацияПоворотаToolStripMenuItem.Name = "демонстрацияПоворотаToolStripMenuItem";
            this.демонстрацияПоворотаToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.демонстрацияПоворотаToolStripMenuItem.Text = "демонстрация поворота";
            this.демонстрацияПоворотаToolStripMenuItem.Click += new System.EventHandler(this.демонстрацияПоворотаToolStripMenuItem_Click);
            // 
            // демонстрацияСжатияToolStripMenuItem
            // 
            this.демонстрацияСжатияToolStripMenuItem.Enabled = false;
            this.демонстрацияСжатияToolStripMenuItem.Name = "демонстрацияСжатияToolStripMenuItem";
            this.демонстрацияСжатияToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.демонстрацияСжатияToolStripMenuItem.Text = "демонстрация сжатия";
            this.демонстрацияСжатияToolStripMenuItem.Click += new System.EventHandler(this.демонстрацияСжатияToolStripMenuItem_Click);
            // 
            // демонстрацияСдвигаИПоворотаToolStripMenuItem
            // 
            this.демонстрацияСдвигаИПоворотаToolStripMenuItem.Enabled = false;
            this.демонстрацияСдвигаИПоворотаToolStripMenuItem.Name = "демонстрацияСдвигаИПоворотаToolStripMenuItem";
            this.демонстрацияСдвигаИПоворотаToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.демонстрацияСдвигаИПоворотаToolStripMenuItem.Text = "демонстрация сдвига и поворота ";
            this.демонстрацияСдвигаИПоворотаToolStripMenuItem.Click += new System.EventHandler(this.демонстрацияСдвигаИПоворотаToolStripMenuItem_Click);
            // 
            // демонстрацияПоворотаИСдвигаToolStripMenuItem
            // 
            this.демонстрацияПоворотаИСдвигаToolStripMenuItem.Enabled = false;
            this.демонстрацияПоворотаИСдвигаToolStripMenuItem.Name = "демонстрацияПоворотаИСдвигаToolStripMenuItem";
            this.демонстрацияПоворотаИСдвигаToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.демонстрацияПоворотаИСдвигаToolStripMenuItem.Text = "демонстрация поворота и сдвига ";
            this.демонстрацияПоворотаИСдвигаToolStripMenuItem.Click += new System.EventHandler(this.демонстрацияПоворотаИСдвигаToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 305);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "График функции и трансформации";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem демонстрацияСдвигаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem демонстрацияПоворотаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem демонстрацияСжатияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem демонстрацияСдвигаИПоворотаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem демонстрацияПоворотаИСдвигаToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;


    }
}

