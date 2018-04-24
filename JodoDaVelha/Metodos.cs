using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JodoDaVelha
{
    public class Metodos
    {
        public int count = 1;
        public string[,] Tabuleiro = new string[3, 3];
        public int[,] nJogados = new int[9,2];

        public string vitoria()
        {
            
            //vitória do O
            if (Tabuleiro[0,0] == "O" && Tabuleiro[0,1] == "O" && Tabuleiro[0,2] == "O")
            {
                return "Vitória do O!";
            }//1
            else if(Tabuleiro[1, 0] == "O" && Tabuleiro[1, 1] == "O" && Tabuleiro[1, 2] == "O")
            {
                return "Vitória do O!";
            }//2
            else if (Tabuleiro[2, 0] == "O" && Tabuleiro[2, 1] == "O" && Tabuleiro[2, 2] == "O")
            {
                return "Vitória do O!";
            }//3
            else if (Tabuleiro[0, 0] == "O" && Tabuleiro[1, 0] == "O" && Tabuleiro[2, 0] == "O")
            {
                return "Vitória do O!";
            }//4
            else if (Tabuleiro[0, 1] == "O" && Tabuleiro[1, 1] == "O" && Tabuleiro[2, 1] == "O")
            {
                return "Vitória do O!";
            }//5
            else if (Tabuleiro[0, 2] == "O" && Tabuleiro[1, 2] == "O" && Tabuleiro[2, 2] == "O")
            {
                return "Vitória do O!";
            }//6
            else if (Tabuleiro[0, 0] == "O" && Tabuleiro[1, 1] == "O" && Tabuleiro[2, 2] == "O")
            {
                return "Vitória do O!";
            }//7
            else if (Tabuleiro[0, 2] == "O" && Tabuleiro[1, 1] == "O" && Tabuleiro[2, 0] == "O")
            {
                return "Vitória do O!";
            }//8

            //vitória do X
            if (Tabuleiro[0, 0] == "X" && Tabuleiro[0, 1] == "X" && Tabuleiro[0, 2] == "X")
            {
                return "Vitória do X!";
            }//1
            else if (Tabuleiro[1, 0] == "X" && Tabuleiro[1, 1] == "X" && Tabuleiro[1, 2] == "X")
            {
                return "Vitória do X!";
            }//2
            else if (Tabuleiro[2, 0] == "X" && Tabuleiro[2, 1] == "X" && Tabuleiro[2, 2] == "X")
            {
                return "Vitória do X!";
            }//3
            else if (Tabuleiro[0, 0] == "X" && Tabuleiro[1, 0] == "X" && Tabuleiro[2, 0] == "X")
            {
                return "Vitória do X!";
            }//4
            else if (Tabuleiro[0, 1] == "X" && Tabuleiro[1, 1] == "X" && Tabuleiro[2, 1] == "X")
            {
                return "Vitória do X!";
            }//5
            else if (Tabuleiro[0, 2] == "X" && Tabuleiro[1, 2] == "X" && Tabuleiro[2, 2] == "X")
            {
                return "Vitória do X!";
            }//6
            else if (Tabuleiro[0, 0] == "X" && Tabuleiro[1, 1] == "X" && Tabuleiro[2, 2] == "X")
            {
                return "Vitória do X!";
            }//7
            else if (Tabuleiro[0, 2] == "X" && Tabuleiro[1, 1] == "X" && Tabuleiro[2, 0] == "X")
            {
                return "Vitória do X!";
            }//8

            else
            {
                return null;
            }

        }//public string vitoria

        public void Bot()
        {
            int cont = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Tabuleiro[i,j] != "O" && Tabuleiro[i, j] != "X")
                    {
                        nJogados[cont, 0] = i;
                        nJogados[cont, 1] = j;
                        cont++;
                    }//if
                }//for j
            }//for i

            Random rdm = new Random();

            int pos = rdm.Next(0, (cont));

            
            if ((count) % 2 == 0)
            {
                Tabuleiro[(nJogados[pos, 0]), (nJogados[pos, 1])] = "O";
            }
            else
            {
                Tabuleiro[(nJogados[pos, 0]), (nJogados[pos, 1])] = "X";
            }
            

            cont = 0;


        }//bot()

        



    }
}
