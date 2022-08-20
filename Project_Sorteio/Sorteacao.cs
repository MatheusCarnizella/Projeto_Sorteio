using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sorteio
{
    internal class Sorteacao
    {
        enum SORTEAR{Cadastro = 1, Sorteio, Exclusao, Fechar = 9};
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
                Console.WriteLine("\n1 - Nomes que deseja sortear\n2 - Sorteie\n3 - Excluir fila do sorteio\n\n\n9 - Fim da aplicacao");
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
                    case SORTEAR.Exclusao:
                        Exclusao();
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
                while (z == 0)
                {
                    Console.Clear();
                    string Nome;
                    Console.WriteLine("Escreva um nome para sortear:");
                    Console.WriteLine("");
                    Nome = Console.ReadLine();

                    //Evitar de deixar o campo "Nome" vazio
                    if (String.IsNullOrEmpty(Nome))
                    {
                        Console.Clear();
                        Console.WriteLine("Voce precisa escrever algo valido.");
                        Console.ReadLine();
                        break;
                    }

                    else
                    {
                        Console.Clear();
                        NOMES.Add(Nome);
                        Console.WriteLine($"{Nome} Foi adicionado a fila.");
                        Console.ReadLine();
                    }
                }
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
                    //Se o usuario nao quiser outro sorteio voltar ao menu 
                    else if (opcao == "N")
                    {
                        Console.Clear();
                        break;
                    }

                    else if (opcao == "n")
                    {
                        Console.Clear();
                        break;
                    }
                }
                //Sistema de exclusao de fila/lista ou de nao exclusao de fila/lista
                Console.Clear();

                Console.WriteLine("Deseja excluir a fila? S ou N? Digite:");
                Console.WriteLine("");
                string escolha = Console.ReadLine();

                //Excluir lista e voltar ao menu
                if (escolha == "S")
                {
                    Console.Clear();
                    NOMES.Clear();
                    Console.WriteLine("Fila excluida. Faca uma nova lista para outro sorteio.");
                    Console.WriteLine("");
                    Console.WriteLine("Pressione ENTER para voltar.");
                    Console.WriteLine("");
                    Console.ReadKey();
                }

                if (escolha == "s")
                {
                    Console.Clear();
                    NOMES.Clear();
                    Console.WriteLine("Fila excluida. Faca uma nova lista para outro sorteio.");
                    Console.WriteLine("");
                    Console.WriteLine("Pressione ENTER para voltar.");
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                //Nao excluir lista e voltar ao menu
                else if (escolha == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Fila nao foi excluida. Voce pode utiliza-la novamente.");
                    Console.WriteLine("");
                    Console.WriteLine("Pressione ENTER para voltar.");
                    Console.WriteLine("");
                    Console.ReadKey();
                }

                else if (escolha == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Fila nao foi excluida. Voce pode utiliza-la novamente");
                    Console.WriteLine("");
                    Console.WriteLine("Pressione ENTER para voltar.");
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                Console.ReadLine();
            }           

        }
        //Sistema de exclusao de lista avulso
        static void Exclusao()
        {
            Console.Clear();
            Console.WriteLine("Nomes na fila para o sorteio:");
            Console.WriteLine("____________________________");
            Console.WriteLine("");

            foreach (string N in NOMES)
            {
                Console.WriteLine(N);
                Console.WriteLine("");
            }

            Console.WriteLine("Voce esta prestes a excluir sua fila de sorteio.");
            Console.WriteLine("");
            Console.WriteLine("Tem certeza que deseja exclui-la? S ou N? Digite:");
            Console.WriteLine("");
            string escolha = Console.ReadLine();

            //Excluir
            if(escolha == "S")
            {
                Console.Clear();
                NOMES.Clear();
                Console.WriteLine("Fila excluida. Faca uma nova fila para outro sorteio.");
                Console.WriteLine("");
                Console.WriteLine("Pressione ENTER para voltar.");
                Console.ReadKey();
            }

            if (escolha == "s")
            {
                Console.Clear();
                NOMES.Clear();
                Console.WriteLine("Fila excluida. Faca uma nova fila para outro sorteio.");
                Console.WriteLine("");
                Console.WriteLine("Pressione ENTER para voltar.");
                Console.ReadKey();
            }

            //Opcao de nao excluir caso tenha entrado por engano
            else if (escolha == "N")
            {
                Console.Clear();
                Console.WriteLine("Tudo bem. Deve ter sido apenas um erro.");
                Console.WriteLine("");
                Console.WriteLine("Pressione ENTER para voltar.");
                Console.ReadKey();
            }

            else if (escolha == "n")
            {
                Console.Clear();
                Console.WriteLine("Tudo bem. Deve ter sido apenas um erro.");
                Console.WriteLine("");
                Console.WriteLine("Pressione ENTER para voltar.");
                Console.ReadKey();
            }
        }
    }
}
