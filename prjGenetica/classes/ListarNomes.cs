using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjGenetica.classes
{
    public static class ListarNomes
    {

        #region Variáveis globais

        public static string[,] nomes = new string[28,2];
        private static int repeticao = 1;

        #endregion

        #region Listar Nomes

        public static void listarNomes()
        {
            nomes[0, 0] = "Robin";
            nomes[1, 0] = "Hebert";
            nomes[2, 0] = "Aruan";
            nomes[3, 0] = "Teddy";
            nomes[4, 0] = "Jamie";
            nomes[5, 0] = "Sandy";
            nomes[6, 0] = "Willy";
            nomes[7, 0] = "Charlie";
            nomes[8, 0] = "Loki";
            nomes[9, 0] = "Chris";
            nomes[10, 0] = "Alex";
            nomes[11, 0] = "Yuri";
            nomes[12, 0] = "Levi";
            nomes[13, 0] = "Luan";
            nomes[14, 0] = "Íris";
            nomes[15, 0] = "Ariel";
            nomes[16, 0] = "Lucca";
            nomes[17, 0] = "Noah";
            nomes[18, 0] = "Ravi";
            nomes[19, 0] = "Alison";
            nomes[20, 0] = "Adriel";
            nomes[21, 0] = "Cenorinha";
            nomes[22, 0] = "Elli";
            nomes[23, 0] = "Peper";
            nomes[24, 0] = "Happy";
            nomes[25, 0] = "Izzy";
            nomes[26, 0] = "Folks";
            nomes[27, 0] = "Sam";
            for (int i = 0; i < nomes.Length/2; i++)
            {
                nomes[i, 1] = "0";
            }
        }

        #endregion

        #region Resetar Nomes

        public static void resetarNomes()
        {
            repeticao++;
            if (repeticao > 2)
            {
                for (int i = 0; i < nomes.Length / 2; i++)
                {
                    nomes[i, 0] = nomes[i, 0].Substring(0, nomes[i, 0].Length-1);
                    nomes[i, 0] += repeticao.ToString();
                }
            }
            else
            {
                for (int i = 0; i < nomes.Length / 2; i++)
                {
                    nomes[i, 0] += repeticao.ToString();
                }
            }
            for (int i = 0; i < nomes.Length / 2; i++)
            {
                nomes[i, 1] = "0";
            }
        }

        #endregion

    }
}
