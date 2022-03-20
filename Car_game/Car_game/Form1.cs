using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_game
{
    public partial class Form1 : Form
    {
        int viteza_joc = 5;
        int banutiColectati = 0;
        public Form1()
        {
            InitializeComponent();
            gameOver.Visible = false;
<<<<<<< HEAD
            closeButton.Visible = false;
=======
            button1.Visible = false;
            button2.Visible = false;
>>>>>>> 6e93c52b8b4133f951acba8599cd9bf1ef24bca5
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(viteza_joc);
            inamic(viteza_joc);
            aiPierdut();
            miscareBanuti(viteza_joc);
            strangeBanuti();
        }
        void moveline(int speed)
        {
            if (pictureBox1.Top >= this.ClientRectangle.Height)
            { pictureBox1.Top = -pictureBox1.Height; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= this.ClientRectangle.Height)
            { pictureBox2.Top = -pictureBox2.Height; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= this.ClientRectangle.Height)
            { pictureBox3.Top = -pictureBox3.Height; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= this.ClientRectangle.Height)
            { pictureBox4.Top = -pictureBox4.Height; }
            else { pictureBox4.Top += speed; }

            if (pictureBox5.Top >= this.ClientRectangle.Height)
            { pictureBox5.Top = -pictureBox5.Height; ; }
            else { pictureBox5.Top += speed; }
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int spdLR = 8;
            if (e.KeyCode == Keys.Left)
            {
                if (masina.Left > pictureBox7.Width/2)
                { masina.Left += -spdLR; }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (masina.Left < this.ClientRectangle.Width-masina.Width-pictureBox7.Width/2) 
                { masina.Left += spdLR; }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (viteza_joc <= 15)
                {
                    viteza_joc++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (viteza_joc >=5)
                {
                    viteza_joc--;
                }
            }
        }

        Random r = new Random();
        int poz_inamic_x;
        void inamic(int speed)
        {
            if (inamic1.Top >= ClientRectangle.Height)
            { 
                inamic1.Top = -inamic1.Height;
                poz_inamic_x = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2-inamic1.Width);
                inamic1.Left = poz_inamic_x;
            }
            else{ inamic1.Top += speed; }

            if (inamic2.Top >= ClientRectangle.Height)
            {
                inamic2.Top = -inamic2.Height;
                poz_inamic_x = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - inamic2.Width);
                inamic2.Left = poz_inamic_x;
            }
            else { inamic2.Top += speed; }

            if (inamic3.Top >= ClientRectangle.Height)
            {
                inamic3.Top = -inamic3.Height;
                poz_inamic_x = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - inamic3.Width);
                inamic3.Left = poz_inamic_x;
            }
            else { inamic3.Top += speed; }

        }

        void aiPierdut()
        {
            if (masina.Bounds.IntersectsWith(inamic1.Bounds))
            {
                timer1.Enabled = false;
                closeButton.Visible = true;
                gameOver.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
            if (masina.Bounds.IntersectsWith(inamic2.Bounds))
            {
                timer1.Enabled = false;
                closeButton.Visible = true;
                gameOver.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
            if (masina.Bounds.IntersectsWith(inamic3.Bounds))
            {
                timer1.Enabled = false;
                closeButton.Visible = true;
                gameOver.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
        }

        int poz_banut;
        void miscareBanuti(int speed) {
            if (banut1.Top >= ClientRectangle.Height)
            {
                banut1.Top = -banut1.Height;
                poz_banut = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - banut1.Width);
                banut1.Left = poz_banut;
            }
            else { banut1.Top += speed; }

            if (banut2.Top >= ClientRectangle.Height)
            {
                banut2.Top = -banut2.Height;
                poz_banut = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - banut2.Width);
                banut2.Left = poz_banut;
            }
            else { banut2.Top += speed; }
            if (banut3.Top >= ClientRectangle.Height)
            {
                banut3.Top = -banut3.Height;
                poz_banut = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - banut3.Width);
                banut3.Left = poz_banut;
            }
            else { banut3.Top += speed; }
            if (banut4.Top >= ClientRectangle.Height)
            {
                banut4.Top = -banut4.Height;
                poz_banut = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - banut4.Width);
                banut4.Left = poz_banut;
            }
            else { banut4.Top += speed; }
            if (banut5.Top >= ClientRectangle.Height)
            {
                banut5.Top = -banut5.Height;
                poz_banut = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - banut5.Width);
                banut5.Left = poz_banut;
            }
            else { banut5.Top += speed; }
        }

        void strangeBanuti()
        {
            if (masina.Bounds.IntersectsWith(banut1.Bounds))
            {
                banut1.Top = -banut1.Height;
                poz_banut = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - banut1.Width);
                banut1.Left = poz_banut;
                banutiColectati += 50;
                scor.Text = "Banuti: " + banutiColectati.ToString();
            }
            if (masina.Bounds.IntersectsWith(banut2.Bounds))
            {
                banut2.Top = -banut2.Height;
                poz_banut = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - banut2.Width);
                banut2.Left = poz_banut;
                banutiColectati += 10;
                scor.Text = "Banuti: " + banutiColectati.ToString();
            }
            if (masina.Bounds.IntersectsWith(banut3.Bounds))
            {
                banut3.Top = -banut3.Height;
                poz_banut = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - banut3.Width);
                banut3.Left = poz_banut;
                banutiColectati += 50;
                scor.Text = "Banuti: " + banutiColectati.ToString();
            }
            if (masina.Bounds.IntersectsWith(banut4.Bounds))
            {
                banut4.Top = -banut4.Height;
                poz_banut = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - banut4.Width);
                banut4.Left = poz_banut;
                banutiColectati += 10;
                scor.Text = "Banuti: " + banutiColectati.ToString();
            }
            if (masina.Bounds.IntersectsWith(banut5.Bounds))
            {
                banut5.Top = -banut5.Height;
                poz_banut = r.Next(pictureBox6.Width / 2, ClientRectangle.Width - pictureBox7.Width / 2 - banut5.Width);
                banut5.Left = poz_banut;
                banutiColectati += 50;
                scor.Text = "Banuti: " + banutiColectati.ToString();
            }

        }

        void restartGame()
        {
            this.Hide();
            var form2 = new Form1();
            form2.Show();
        }

        void exitGame()
        {
            this.Close();
            Application.Exit();
        }

        private void inamic1_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
=======
        private void button1_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
>>>>>>> 6e93c52b8b4133f951acba8599cd9bf1ef24bca5
        }
    }
}
