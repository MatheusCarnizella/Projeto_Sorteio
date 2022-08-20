using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sorteio
{
    internal class Program
    {
        enum SORTEAR{Cadastro = 1, Sorteio, Fechar = 9};
        static void Main(string[] args)
        {
            // Bem-vindo
            Console.WriteLine("Bem-vindo ao sistema de sorteio para qualquer ocasiao!");
            Console.WriteLine("");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.WriteLine("");
            Console.ReadKey();

            // Criacao de botao sair
            bool sair = false;
            while (!sair)
            {
                // Cabecalho
                Console.Clear();
                Console.WriteLine("Selecione a opcao desejada:");
                Console.WriteLine("1 - Nomes que deseja sortear\n2 - Sorteie\n\n\n9 - Fim da aplicacao");
                Console.WriteLine("");
                int sort = int.Parse(Console.ReadLine());

                // Criacao de Menu de interacao
                SORTEAR sortear = (SORTEAR) sort;
                switch (sortear)
                {
                    case SORTEAR.Cadastro:
                        Cadastro();
                        break;
                    case SORTEAR.Sorteio:
                        Sorteio();
                        break;
                    case SORTEAR.Fechar:
                        sair = true;
                        break;
                }
            }

        }
        static List<string> NOMES = new List<string>();
        // Criando sistema para colocar nome do sorteio numa fila/lista
        static void Cadastro()
        {
            Console.Clear();
            Console.WriteLine("Digite quantos nomes deseja por na fila do sorteio: ");
            Console.WriteLine("");
            int q = int.Parse(Console.ReadLine());
            for (int z = 0; z < q; z++)
            {
                Console.Clear();
                string Nome;
                Console.WriteLine("Escreva um nome para sortear:");
                Console.WriteLine("");
                Nome = Console.ReadLine();
                Console.Clear();
                NOMES.Add(Nome);
                Console.WriteLine($"{Nome} Foi adicionado a fila.");
                Console.ReadLine();
            }         

        }
        //Criando sistema para pegar um nome da fila/lista mostra-lo como vencedor
        static string resultado;
        static void Sorteio()
        {
            Console.Clear();
            Random sortear = new Random();
            //Sistema de seguranca caso nao exista fila para sorteio
            if (NOMES.Count == 0)
            {
                Console.WriteLine("Nao existe fila para sortear.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Nomes na fila para o sorteio:");
                Console.WriteLine("____________________________");
                Console.WriteLine("");

                foreach (string N in NOMES)
                {
                    Console.WriteLine(N);
                    Console.WriteLine("");
                }

                Console.WriteLine("Precione ENTER para ver o vencedor.");
                Console.ReadLine();
                Console.ReadKey();
                Console.Clear();
                //Sistema para sorteio de uma lista

                resultado = NOMES[sortear.Next(NOMES.Count)];
                Console.WriteLine("E o vencedor do sorteio foi:");
                Console.WriteLine("");
                Console.WriteLine(resultado);
                Console.WriteLine("");
                Console.WriteLine("Parabens!!!");
                Console.ReadLine();
                Console.Clear();


                //Sistema para caso a pessoa queira fazer outro sorteio com a mesma fila/lista
                while (resultado != null)
                {
                    Console.Clear();
                    Console.WriteLine("Deseja fazer outro sorteio? S ou N? Digite:");
                    Console.WriteLine("");
                    string opcao = Console.ReadLine();
                    if (opcao == "S")
                    {
                        Console.Clear();
                        resultado = NOMES[sortear.Next(NOMES.Count)];
                        Console.WriteLine("E o vencedor do sorteio foi:");
                        Console.WriteLine("");
                        Console.WriteLine(resultado);
                        Console.WriteLine("");
                        Console.WriteLine("Parabens!!!");
                        Console.ReadLine();
                    }

                    if (opcao == "s")
                    {
                        Console.Clear();
                        resultado = NOMES[sortear.Next(NOMES.Count)];
                        Console.WriteLine("E o vencedor do sorteio foi:");
                        Console.WriteLine("");
                        Console.WriteLine(resultado);
                        Console.WriteLine("");
                        Console.WriteLine("Parabens!!!");
                        Console.ReadLine();
                    }
                    //Se o usuario nao quiser outro sorteio voltar ao menu e excluir a fila/lista
                    else if (opcao == "N")
                    {
                        Console.Clear();
                        Console.WriteLine("Pressione ENTER para voltar.");
                        Console.ReadKey();
                        NOMES.Clear();
                        break;
                    }

                    else if (opcao == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("Pressione ENTER para voltar.");
                        Console.ReadKey();
                        NOMES.Clear();
                        break;
                    }

                }
            }
            


        }
    }
}
