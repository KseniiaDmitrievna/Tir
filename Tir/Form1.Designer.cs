namespace Tir
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBoxHeight = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxWidth = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(22, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 562);
            this.panel1.TabIndex = 26;
            // 
            // tBoxHeight
            // 
            this.tBoxHeight.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tBoxHeight.Location = new System.Drawing.Point(122, 56);
            this.tBoxHeight.Multiline = true;
            this.tBoxHeight.Name = "tBoxHeight";
            this.tBoxHeight.Size = new System.Drawing.Size(86, 31);
            this.tBoxHeight.TabIndex = 21;
            this.tBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStop.Location = new System.Drawing.Point(504, 56);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 31);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Сначала";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStart.Location = new System.Drawing.Point(418, 56);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 31);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Выберите скорость\r\nперемещения мишени:\r\n";
            // 
            // cmbBoxTime
            // 
            this.cmbBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbBoxTime.FormattingEnabled = true;
            this.cmbBoxTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbBoxTime.Location = new System.Drawing.Point(292, 63);
            this.cmbBoxTime.Name = "cmbBoxTime";
            this.cmbBoxTime.Size = new System.Drawing.Size(94, 24);
            this.cmbBoxTime.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Введите размер:";
            // 
            // tBoxWidth
            // 
            this.tBoxWidth.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tBoxWidth.Location = new System.Drawing.Point(22, 56);
            this.tBoxWidth.Multiline = true;
            this.tBoxWidth.Name = "tBoxWidth";
            this.tBoxWidth.Size = new System.Drawing.Size(86, 31);
            this.tBoxWidth.TabIndex = 20;
            this.tBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar.Location = new System.Drawing.Point(28, 705);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(556, 33);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 19;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 765);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tBoxHeight);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoxTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxWidth);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Тир";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tBoxHeight;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxWidth;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}

