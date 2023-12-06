using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tir
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        Button[,] ArrayButton;
        List<Button> listButton = new List<Button>();
        Random rnd = new Random();
        Button btnNow = new Button();
        Button btnAfter = new Button();
        int targetRedLast, noun, targetRed, targetAmount, targetKill, width, height, speed;

        

        bool flag;


        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                width = Convert.ToInt32(tBoxWidth.Text);
                height = Convert.ToInt32(tBoxHeight.Text);
                if (width > 15 | height > 15)
                {
                    MessageBox.Show("Размер не должен превышать 15!");
                    Application.Restart();
                }
                generationMishen(width, height);
                targetAmount = width * height;
            }
            catch
            {
                MessageBox.Show("Вы ввели неверный формат размера. Попробуйте снова.");
                Application.Restart();
            }
        }

        public void generationMishen(int width, int height)
        {
            ArrayButton = new Button[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    ArrayButton[i, j] = new Button();
                    ArrayButton[i, j].Location = new Point(i * 30, j * 30);
                    ArrayButton[i, j].Size = new Size(25, 25);
                    ArrayButton[i, j].BackColor = Color.Blue;

                    panel1.Controls.Add(ArrayButton[i, j]);

                    ArrayButton[i, j].Click += Click_Picture;

                    listButton.Add(ArrayButton[i, j]);
                }
            }

           
            if (cmbBoxTime.Text == "1") { speed = 2000; }
            else if (cmbBoxTime.Text == "2") { speed = 1000; }
            else { speed = 800; }

            timer.Interval = speed;
            timer.Enabled = true;
            timer.Tick += new EventHandler(Timer_Tick);

            progressBar.Visible = true;
            progressBar.Minimum = 0;
            progressBar.Maximum = ArrayButton.Length;
            progressBar.Value = 0;
            progressBar.Step = 1;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Click_Picture(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).BackColor == Color.Red)
                {
                    noun++;
                    progressBar.PerformStep();
                }
            }
            catch { }

            listButton.Remove(sender as Button);

            (sender as Button).Visible = false;
            btnNow = null;

            targetKill++;

            if (targetKill == targetAmount)
            {
                timer.Stop();
                MessageBox.Show(Convert.ToString("Набрано очков:  " + Convert.ToString(noun)));
                Application.Restart();
            }

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (listButton.Count == 1 & flag == false)
            {
                listButton[0].BackColor = Color.Red;

            }
            else if (listButton.Count == 1 & flag == true)
            {
                listButton[0].BackColor = Color.Blue;
            }
            else
            {
                while (targetRed == targetRedLast)
                {
                    targetRed = rnd.Next(0, listButton.Count);
                }

                listButton[targetRed].BackColor = Color.Red;
                btnNow = listButton[targetRed];
                if (btnAfter != null)
                {
                    btnAfter.BackColor = Color.Blue;
                }

                targetRedLast = targetRed;
                btnAfter = btnNow;
            }
            if (flag == true) { flag = false; }
            else { flag = true; }
        }
    }
}
