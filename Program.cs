using System;

namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 1

            int n;
            Console.Write("Introduz um número inteiro de 1 a 10: ");
            n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

            int table;

            for (n = 1; n >= 1 && n <= 10; n++)
            {
                table = 5 * n;

                Console.WriteLine("5 X {0} = {1}", n, table);
            }


            Console.ReadKey();
            Console.Clear();

            // // Exercicio 2

            int table1;
            int n1;
            int n2;

            Console.Write("Introduz um número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduz um segundo inteiro de 1 a 10: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            
    Console.WriteLine();

            for (table1 = n1 * n2; n2 >= 1 && n2 <= 10; n2++)
            {
                table1 = n1 * n2;
                Console.WriteLine("{0} X {1} = {2}", n1, n2, table1);

            }

            Console.ReadKey();
            Console.Clear();

            // Exercicio 3

            int nl, coluna, linha;
           
           Console.Write("Quantas linhas pretende? ");
           nl = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

            for (linha= 1; linha >= 1 && linha <= nl; linha++)
            {
                for (coluna=1; coluna >= 1 && coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
            Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();

            // Exercicio 4

            int escolha, horizontal, espaco, asterisco;

            Console.Write("Com quantas linhas pretende construir a piramide? ");
            escolha = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

            for (horizontal = 1; horizontal <= escolha; horizontal++)
            {
                for (espaco = 0; espaco < escolha - horizontal; espaco++)
                {
                    Console.Write(" ");
                }
                for (asterisco = 0; asterisco < horizontal; asterisco++)
                {
                    Console.Write("**");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();


            // Exercicio 5


            int mp, line, column;

            Console.Write("Quantas linhas da meia piramide pretende? ");
            mp = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

            line = 1;
            do
            {
                Console.Write("");
                line++;
                column = 2;
                do
                {
                    Console.Write("*");
                    column++;
                } while (column <= line);
                Console.WriteLine();
            } while (line <= mp);

            Console.ReadKey();
            Console.Clear();


            // Exercicio 6


            Console.Write("Quantas linhas pretende? ");
            int numero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

            int linhas = 1;
            while (linhas <= numero)
            {
                int colunas = 1;
                while (colunas <= linhas)
                {
                    Console.Write("*");
                    colunas++;
                }
                Console.WriteLine();
                linhas++;
            }

            Console.ReadKey();
            Console.Clear();


            // Exercicio 7

            int lp, linhap, espacop, asteriscop;

            Console.Write("Quantas linhas pretende na piramide? ");
            lp = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

            linhap = 1;

            do
            {
                Console.Write("");
                espacop = 0;
                do
                {
                    Console.Write(" ");
                    espacop++;

                } while (espacop <= lp - linhap);

                linhap++;

                asteriscop = 1;
                do
                {
                    Console.Write("**");
                    asteriscop++;

                } while (asteriscop < linhap);

                Console.WriteLine("  ");
            } while (linhap <= lp);

            
            Console.ReadKey();
            Console.Clear();


            // Exercicio 8

            int odd;

            Console.Write("Com quantas linhas pretende construir a piramide? ");
            odd = Convert.ToInt32(Console.ReadLine());

            for (int linha2 = 0; linha2 < odd; linha2++)
            {
                for (int espaco2 = 0; espaco2 < odd - linha2 - 1; espaco2++)
                {
                    Console.Write(" ");
                }
                for (int estrela = 0; estrela < linha2 * 2 + 1; estrela++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();


            // Exercicio 9

            int equal;

            Console.Write("Com quantas linhas pretende construir a piramide? ");
            equal = Convert.ToInt32(Console.ReadLine());

            for (int linhas9 = 1; linhas9 <= equal; linhas9++)
            {
                for (int espacos9 = 1; espacos9 <= equal - linhas9; espacos9++)
                {
                    Console.Write(" ");
                }
                for (int estrela9 = 1; estrela9 <= linhas9; estrela9++)
                {
                    Console.Write(" *");
                }
                for (int espacos9 = 1; espacos9 <= linhas9 -1; espacos9++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }



        }
    }
}
