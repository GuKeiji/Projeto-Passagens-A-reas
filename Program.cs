using System;

namespace ProjetoPassagensAereas
{
    class Program
    {
        static void Main(string[] args)
        {
            int i2 = 0;
            bool check1 = true;
            bool check = true;
            int selecionar;
            string resposta = "s";
            // string resposta2 = "s";
            string texto = "";
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            double[] dataVoo = new double[5];

            while (check1 == true)
            {
                Console.WriteLine($"Digite sua senha {texto} para acessar o menu:");
                int senha = int.Parse(Console.ReadLine());
                if (senha == 123456)
                {
                    while (check == true)
                    {
                        Console.WriteLine($@"
---------------------------------------------------------------------
|   1-CADASTRAR PASSAGEM        2-LISTAR PASSAGEM           0-SAIR  |        
---------------------------------------------------------------------

Escolha uma das opções:
                ");
                        selecionar = int.Parse(Console.ReadLine());
                        if (selecionar == 1)
                        {
                            for (var i = 0; i <= 5; i++)
                            {
                                Console.WriteLine("Digite seu nome:");
                                nome[i] = Console.ReadLine();
                                Console.WriteLine("Digite sua origem:");
                                origem[i] = Console.ReadLine();
                                Console.WriteLine("Digite seu destino:");
                                destino[i] = Console.ReadLine();
                                Console.WriteLine("Digite a data do voo: (dd.mm.aaaa");
                                dataVoo[i] = double.Parse(Console.ReadLine());
                                Console.WriteLine("Deseja cadastrar outro passageiro? (S/N)");
                                resposta = Console.ReadLine().ToLower();
                                i2++;
                                Console.WriteLine(nome[i]);
                                Console.WriteLine(origem[i]);
                                Console.WriteLine(destino[i]);
                                Console.WriteLine(dataVoo[i]);
                                if (resposta == "n")
                                {
                                    break;
                                }
                            }
                        }
                        else if (selecionar == 2)
                        {
                            for (var i = 0; i < i2; i++)
                            {

                                Console.WriteLine($@"
----------------------------
|   {i + 1}º Cadastro          |        
|--------------------------|    
|      {nome[i]}           |
|      {origem[i]}         |
|      {destino[i]}        |
|      {dataVoo[i]}        |
----------------------------
                            ");
                            }
                        }
                        else
                        {
                            check = false;
                        }

                    }
                }


                else
                {
                    Console.WriteLine("Senha inválida");
                    texto = "novamente";
                    // check = false;
                }
            }




        }
    }
}
