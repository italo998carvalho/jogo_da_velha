using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JodoDaVelha
{
    public partial class Mesa1J : Form
    {
        Metodos metodo = new Metodos();

        public void botJogada()
        {
            metodo.Bot();

            if(metodo.Tabuleiro[0,0] == "O")
            {
                btn00.Text = "O";
                btn00.BackColor = Color.Blue;
                btn00.Enabled = false;
            }
            else if(metodo.Tabuleiro[0, 0] == "X")
            {
                btn00.Text = "X";
                btn00.BackColor = Color.Red;
                btn00.Enabled = false;
            }//btn00

            if (metodo.Tabuleiro[0, 1] == "O")
            {
                btn01.Text = "O";
                btn01.BackColor = Color.Blue;
                btn01.Enabled = false;
            }
            else if (metodo.Tabuleiro[0, 1] == "X")
            {
                btn01.Text = "X";
                btn01.BackColor = Color.Red;
                btn01.Enabled = false;
            }//btn01

            if (metodo.Tabuleiro[0, 2] == "O")
            {
                btn02.Text = "O";
                btn02.BackColor = Color.Blue;
                btn02.Enabled = false;
            }
            else if (metodo.Tabuleiro[0, 2] == "X")
            {
                btn02.Text = "X";
                btn02.BackColor = Color.Red;
                btn02.Enabled = false;
            }//btn02

            if (metodo.Tabuleiro[1, 0] == "O")
            {
                btn10.Text = "O";
                btn10.BackColor = Color.Blue;
                btn10.Enabled = false;
            }
            else if (metodo.Tabuleiro[1, 0] == "X")
            {
                btn10.Text = "X";
                btn10.BackColor = Color.Red;
                btn10.Enabled = false;
            }//btn10

            if (metodo.Tabuleiro[1, 1] == "O")
            {
                btn11.Text = "O";
                btn11.BackColor = Color.Blue;
                btn11.Enabled = false;
            }
            else if (metodo.Tabuleiro[1, 1] == "X")
            {
                btn11.Text = "X";
                btn11.BackColor = Color.Red;
                btn11.Enabled = false;
            }//btn11

            if (metodo.Tabuleiro[1, 2] == "O")
            {
                btn12.Text = "O";
                btn12.BackColor = Color.Blue;
                btn12.Enabled = false;
            }
            else if (metodo.Tabuleiro[1, 2] == "X")
            {
                btn12.Text = "X";
                btn12.BackColor = Color.Red;
                btn12.Enabled = false;
            }//btn12

            if (metodo.Tabuleiro[2, 0] == "O")
            {
                btn20.Text = "O";
                btn20.BackColor = Color.Blue;
                btn20.Enabled = false;
            }
            else if (metodo.Tabuleiro[2, 0] == "X")
            {
                btn20.Text = "X";
                btn20.BackColor = Color.Red;
                btn20.Enabled = false;
            }//btn20

            if (metodo.Tabuleiro[2, 1] == "O")
            {
                btn21.Text = "O";
                btn21.BackColor = Color.Blue;
                btn21.Enabled = false;
            }
            else if (metodo.Tabuleiro[2, 1] == "X")
            {
                btn21.Text = "X";
                btn21.BackColor = Color.Red;
                btn21.Enabled = false;
            }//btn21

            if (metodo.Tabuleiro[2, 2] == "O")
            {
                btn22.Text = "O";
                btn22.BackColor = Color.Blue;
                btn22.Enabled = false;
            }
            else if (metodo.Tabuleiro[2, 2] == "X")
            {
                btn22.Text = "X";
                btn22.BackColor = Color.Red;
                btn22.Enabled = false;
            }//btn22
            
            if((metodo.count) % 2 == 0)
            {
                gb1.Text = "Vez do X";
            }
            else
            {
                gb1.Text = "Vez do O";
            }
        }//botJogada()

        public void desabilitarBtn()
        {
            btn00.Enabled = false;
            btn01.Enabled = false;
            btn02.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn20.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;
        }//desabilitarBtn

        public void Reset()
        {
            btn00.Text = " ";
            btn01.Text = " ";
            btn02.Text = " ";
            btn10.Text = " ";
            btn11.Text = " ";
            btn12.Text = " ";
            btn20.Text = " ";
            btn21.Text = " ";
            btn22.Text = " ";

            metodo.count = 1;

            metodo.Tabuleiro[0, 0] = " ";
            metodo.Tabuleiro[0, 1] = " ";
            metodo.Tabuleiro[0, 2] = " ";
            metodo.Tabuleiro[1, 0] = " ";
            metodo.Tabuleiro[1, 1] = " ";
            metodo.Tabuleiro[1, 2] = " ";
            metodo.Tabuleiro[2, 0] = " ";
            metodo.Tabuleiro[2, 1] = " ";
            metodo.Tabuleiro[2, 2] = " ";

            btn00.Enabled = true;
            btn01.Enabled = true;
            btn02.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;

            btn00.BackColor = SystemColors.Control;
            btn01.BackColor = SystemColors.Control;
            btn02.BackColor = SystemColors.Control;
            btn10.BackColor = SystemColors.Control;
            btn11.BackColor = SystemColors.Control;
            btn12.BackColor = SystemColors.Control;
            btn20.BackColor = SystemColors.Control;
            btn21.BackColor = SystemColors.Control;
            btn22.BackColor = SystemColors.Control;

            gb1.Text = " ";
        }//Reset()

        public Mesa1J()
        {
            InitializeComponent();
            btn00.BackColor = SystemColors.Control;
            btn01.BackColor = SystemColors.Control;
            btn02.BackColor = SystemColors.Control;
            btn10.BackColor = SystemColors.Control;
            btn11.BackColor = SystemColors.Control;
            btn12.BackColor = SystemColors.Control;
            btn20.BackColor = SystemColors.Control;
            btn21.BackColor = SystemColors.Control;
            btn22.BackColor = SystemColors.Control;
            btnReset.BackColor = SystemColors.Control;
            btnBack.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        public void btn00_Click(object sender, EventArgs e)
        {
            if ((metodo.count) % 2 == 0)
            {
                btn00.Text = "O";
                btn00.BackColor = Color.Blue;
                metodo.Tabuleiro[0, 0] = "O";
                gb1.Text = "Vez do X";
            }
            else
            {
                btn00.Text = "X";
                btn00.BackColor = Color.Red;
                metodo.Tabuleiro[0, 0] = "X";
                gb1.Text = "Vez do O";
            }

            btn00.Enabled = false;

            metodo.count++;

            if (metodo.vitoria() != null)
            {
                gb1.Text = metodo.vitoria();
                desabilitarBtn();
            }

            if (metodo.count == 10 && metodo.vitoria() == null)
            {
                gb1.Text = "Empate!";
                desabilitarBtn();
            }

            if (metodo.vitoria() == null)
            {
                botJogada();

                if (metodo.vitoria() != null)
                {
                    gb1.Text = metodo.vitoria();
                    desabilitarBtn();
                }

                if (metodo.count == 10 && metodo.vitoria() == null)
                {
                    gb1.Text = "Empate!";
                    desabilitarBtn();
                }

                metodo.count++;
            }

        }//btn00

        
        private void btn01_Click(object sender, EventArgs e)
        {
            if ((metodo.count) % 2 == 0)
            {
                btn01.Text = "O";
                btn01.BackColor = Color.Blue;
                metodo.Tabuleiro[0, 1] = "O";
                gb1.Text = "Vez do X";
            }
            else
            {
                btn01.Text = "X";
                btn01.BackColor = Color.Red;
                metodo.Tabuleiro[0, 1] = "X";
                gb1.Text = "Vez do O";
            }

            btn01.Enabled = false;

            metodo.count++;

            if (metodo.vitoria() != null)
            {
                gb1.Text = metodo.vitoria();
                desabilitarBtn();
            }

            if (metodo.count == 10 && metodo.vitoria() == null)
            {
                gb1.Text = "Empate!";
                desabilitarBtn();
            }

            if (metodo.vitoria() == null)
            {
                botJogada();

                if (metodo.vitoria() != null)
                {
                    gb1.Text = metodo.vitoria();
                    desabilitarBtn();
                }

                if (metodo.count == 10 && metodo.vitoria() == null)
                {
                    gb1.Text = "Empate!";
                    desabilitarBtn();
                }

                metodo.count++;
            }
        }//btn01

        private void btn02_Click(object sender, EventArgs e)
        {
            if ((metodo.count) % 2 == 0)
            {
                btn02.Text = "O";
                btn02.BackColor = Color.Blue;
                metodo.Tabuleiro[0, 2] = "O";
                gb1.Text = "Vez do X";
            }
            else
            {
                btn02.Text = "X";
                btn02.BackColor = Color.Red;
                metodo.Tabuleiro[0, 2] = "X";
                gb1.Text = "Vez do O";
            }

            btn02.Enabled = false;

            metodo.count++;

            if (metodo.vitoria() != null)
            {
                gb1.Text = metodo.vitoria();
                desabilitarBtn();
            }

            if (metodo.count == 10 && metodo.vitoria() == null)
            {
                gb1.Text = "Empate!";
                desabilitarBtn();
            }

            if (metodo.vitoria() == null)
            {
                botJogada();

                if (metodo.vitoria() != null)
                {
                    gb1.Text = metodo.vitoria();
                    desabilitarBtn();
                }

                if (metodo.count == 10 && metodo.vitoria() == null)
                {
                    gb1.Text = "Empate!";
                    desabilitarBtn();
                }

                metodo.count++;
            }

        }//btn02

        private void btn10_Click(object sender, EventArgs e)
        {
            if ((metodo.count) % 2 == 0)
            {
                btn10.Text = "O";
                btn10.BackColor = Color.Blue;
                metodo.Tabuleiro[1, 0] = "O";
                gb1.Text = "Vez do X";
            }
            else
            {
                btn10.Text = "X";
                btn10.BackColor = Color.Red;
                metodo.Tabuleiro[1, 0] = "X";
                gb1.Text = "Vez do O";
            }

            btn10.Enabled = false;

            metodo.count++;

            if (metodo.vitoria() != null)
            {
                gb1.Text = metodo.vitoria();
                desabilitarBtn();
            }

            if (metodo.count == 10 && metodo.vitoria() == null)
            {
                gb1.Text = "Empate!";
                desabilitarBtn();
            }

            if (metodo.vitoria() == null)
            {
                botJogada();

                if (metodo.vitoria() != null)
                {
                    gb1.Text = metodo.vitoria();
                    desabilitarBtn();
                }

                if (metodo.count == 10 && metodo.vitoria() == null)
                {
                    gb1.Text = "Empate!";
                    desabilitarBtn();
                }

                metodo.count++;
            }

        }//btn10

        private void btn11_Click(object sender, EventArgs e)
        {
            if ((metodo.count) % 2 == 0)
            {
                btn11.Text = "O";
                btn11.BackColor = Color.Blue;
                metodo.Tabuleiro[1, 1] = "O";
                gb1.Text = "Vez do X";
            }
            else
            {
                btn11.Text = "X";
                btn11.BackColor = Color.Red;
                metodo.Tabuleiro[1, 1] = "X";
                gb1.Text = "Vez do O";
            }

            btn11.Enabled = false;

            metodo.count++;

            if (metodo.vitoria() != null)
            {
                gb1.Text = metodo.vitoria();
                desabilitarBtn();
            }

            if (metodo.count == 10 && metodo.vitoria() == null)
            {
                gb1.Text = "Empate!";
                desabilitarBtn();
            }

            if (metodo.vitoria() == null)
            {
                botJogada();

                if (metodo.vitoria() != null)
                {
                    gb1.Text = metodo.vitoria();
                    desabilitarBtn();
                }

                if (metodo.count == 10 && metodo.vitoria() == null)
                {
                    gb1.Text = "Empate!";
                    desabilitarBtn();
                }

                metodo.count++;
            }

        }//btn11

        private void btn12_Click(object sender, EventArgs e)
        {
            if ((metodo.count) % 2 == 0)
            {
                btn12.Text = "O";
                btn12.BackColor = Color.Blue;
                metodo.Tabuleiro[1, 2] = "O";
                gb1.Text = "Vez do X";
            }
            else
            {
                btn12.Text = "X";
                btn12.BackColor = Color.Red;
                metodo.Tabuleiro[1, 2] = "X";
                gb1.Text = "Vez do O";
            }

            btn12.Enabled = false;

            metodo.count++;

            if (metodo.vitoria() != null)
            {
                gb1.Text = metodo.vitoria();
                desabilitarBtn();
            }

            if (metodo.count == 10 && metodo.vitoria() == null)
            {
                gb1.Text = "Empate!";
                desabilitarBtn();
            }

            if (metodo.vitoria() == null)
            {
                botJogada();

                if (metodo.vitoria() != null)
                {
                    gb1.Text = metodo.vitoria();
                    desabilitarBtn();
                }

                if (metodo.count == 10 && metodo.vitoria() == null)
                {
                    gb1.Text = "Empate!";
                    desabilitarBtn();
                }

                metodo.count++;
            }

        }//btn12

        private void btn20_Click(object sender, EventArgs e)
        {
            if ((metodo.count) % 2 == 0)
            {
                btn20.Text = "O";
                btn20.BackColor = Color.Blue;
                metodo.Tabuleiro[2, 0] = "O";
                gb1.Text = "Vez do X";
            }
            else
            {
                btn20.Text = "X";
                btn20.BackColor = Color.Red;
                metodo.Tabuleiro[2, 0] = "X";
                gb1.Text = "Vez do O";
            }

            btn20.Enabled = false;

            metodo.count++;

            if (metodo.vitoria() != null)
            {
                gb1.Text = metodo.vitoria();
                desabilitarBtn();
            }

            if (metodo.count == 10 && metodo.vitoria() == null)
            {
                gb1.Text = "Empate!";
                desabilitarBtn();
            }

            if (metodo.vitoria() == null)
            {
                botJogada();

                if (metodo.vitoria() != null)
                {
                    gb1.Text = metodo.vitoria();
                    desabilitarBtn();
                }

                if (metodo.count == 10 && metodo.vitoria() == null)
                {
                    gb1.Text = "Empate!";
                    desabilitarBtn();
                }

                metodo.count++;
            }

        }//btn20

        private void btn21_Click(object sender, EventArgs e)
        {
            if ((metodo.count) % 2 == 0)
            {
                btn21.Text = "O";
                btn21.BackColor = Color.Blue;
                metodo.Tabuleiro[2, 1] = "O";
                gb1.Text = "Vez do X";
            }
            else
            {
                btn21.Text = "X";
                btn21.BackColor = Color.Red;
                metodo.Tabuleiro[2, 1] = "X";
                gb1.Text = "Vez do O";
            }

            btn21.Enabled = false;

            metodo.count++;

            if (metodo.vitoria() != null)
            {
                gb1.Text = metodo.vitoria();
                desabilitarBtn();
            }

            if (metodo.count == 10 && metodo.vitoria() == null)
            {
                gb1.Text = "Empate!";
                desabilitarBtn();
            }

            if (metodo.vitoria() == null)
            {
                botJogada();

                if (metodo.vitoria() != null)
                {
                    gb1.Text = metodo.vitoria();
                    desabilitarBtn();
                }

                if (metodo.count == 10 && metodo.vitoria() == null)
                {
                    gb1.Text = "Empate!";
                    desabilitarBtn();
                }

                metodo.count++;
            }

        }//btn21

        private void btn22_Click(object sender, EventArgs e)
        {
            if ((metodo.count) % 2 == 0)
            {
                btn22.Text = "O";
                btn22.BackColor = Color.Blue;
                metodo.Tabuleiro[2, 2] = "O";
                gb1.Text = "Vez do X";
            }
            else
            {
                btn22.Text = "X";
                btn22.BackColor = Color.Red;
                metodo.Tabuleiro[2, 2] = "X";
                gb1.Text = "Vez do O";
            }

            btn22.Enabled = false;
            metodo.count++;


            if (metodo.vitoria() != null)
            {
                gb1.Text = metodo.vitoria();
                desabilitarBtn();
            }

            if (metodo.count == 10 && metodo.vitoria() == null)
            {
                gb1.Text = "Empate!";
                desabilitarBtn();
            }

            if (metodo.vitoria() == null)
            {
                botJogada();

                if (metodo.vitoria() != null)
                {
                    gb1.Text = metodo.vitoria();
                    desabilitarBtn();
                }

                if (metodo.count == 10 && metodo.vitoria() == null)
                {
                    gb1.Text = "Empate!";
                    desabilitarBtn();
                }

                metodo.count++;
            }

        }//btn22

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

    }//class
}//namespace
