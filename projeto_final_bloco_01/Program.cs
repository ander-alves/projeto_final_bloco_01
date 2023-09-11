using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Drawing;

namespace projeto_final_bloco_01
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int option, type, category,id, quantity,age,number;
            string? name,flavor;
            decimal price;

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=====================================================");
                Console.WriteLine("                                                     ");
                LogoBanner();
                Console.WriteLine("                                                     ");
                Console.WriteLine("=====================================================");
                Console.WriteLine("                                                     ");
                Console.WriteLine("            1 - Cadastrar produto                    ");
                Console.WriteLine("            2 - Listar todos os produtos             ");
                Console.WriteLine("            3 - Buscar produto por ID                ");
                Console.WriteLine("            4 - Atualizar Dados de um Produto        ");
                Console.WriteLine("            5 - Apagar Produto                       ");
                Console.WriteLine("            6 - Buscar produto por Nome              ");                
                Console.WriteLine("            9 - Sair                                 ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("=====================================================");
                Console.WriteLine("                                                     ");
                Console.WriteLine("Entre com a opção desejada:                          ");
                Console.WriteLine("                                                     ");
                Console.ResetColor();

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDigite valores inteiros!");
                    option = 0;
                    Console.ResetColor();
                }

                if (option == 9)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nAdegas delivery - Facilitando sua vida");
                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (option)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Cadastrar Produto\n\n");
                        Console.ResetColor();
                        //id = controller.gerarId(); //TODOcriarfuncao
                        Console.WriteLine("Digite o Nome do Produto: ");
                        name = Console.ReadLine();

                        name ??= string.Empty;

                        do
                        {
                            Console.WriteLine("Digite o tipo do Conta (1 - Alcoolico ou 2 - Nao Alcoolico )");
                            type = Convert.ToInt32(Console.ReadLine());
                        } while (type != 1 && type != 2);
                        Console.WriteLine("Digite a Quantidade: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o Valor: ");
                        price = Convert.ToDecimal(Console.ReadLine());

                        switch (type)
                        {
                            case 1:  // Alcoólico
                                Console.WriteLine("Informe o Teor Alcoólico (em %): ");
                                decimal alcoholContent = Convert.ToDecimal(Console.ReadLine());

                                if (alcoholContent <= 0 || alcoholContent > 100)
                                {
                                    throw new Exception("O teor alcoólico deve estar entre 0.1% e 100%.");
                                }
                                //lógica para cadastrar o produto alcoólico.
                                break;

                            case 2:  // Não Alcoólico
                                Console.WriteLine("Informe o Sabor: ");
                                flavor = Console.ReadLine();
                                // lógica para cadastrar o produto não alcoólico.
                                break;
                        }

                        KeyPress();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Listar Todos os Produtos\n\n");
                        Console.ResetColor();

                        //produtos.ListAll();

                        KeyPress();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Consultar Produtos por ID \n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Numero do Produto: ");

                        number = Convert.ToInt32(Console.ReadLine());
                        //produto.ProcurarPorNumero(number);

                        KeyPress();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualizar dados do Produto \n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número do Produto: ");
                        number = Convert.ToInt32(Console.ReadLine());

                        
                        KeyPress();
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Apagar a Produto\n\n");
                        Console.ResetColor();
                        Console.WriteLine("Digite o Numero do Produto: ");

                        number = Convert.ToInt32(Console.ReadLine());
                        //produtos.delete(number);

                        KeyPress();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Buscar Produto por Nome: \n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Numero da Conta: ");
                        name = Console.ReadLine();
                        
                        name ??= string.Empty;

                        //controller.ListarPorName(name);

                        KeyPress();
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção Inválida!\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                }
            }
        }

        static void Sobre()
        {
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Projeto Desenvolvido por: Anderson Alves");
            Console.WriteLine("Email: alves_anderson@outlook.com");
            Console.WriteLine("Generation Brasil - generation@generation.org");
            Console.WriteLine("github.com/ander-alves");
            Console.WriteLine("*********************************************************");

        }

        static void KeyPress()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();

            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }


        static void LogoBanner()
        {
            Console.WriteLine("      _             ____       _ _                      \r\n" +
                "     | | __ _  ___ |  _ \\  ___| (_)_   _____ _ __ _   _ \r\n" +
                "  _  | |/ _` |/ _ \\| | | |/ _ \\ | \\ \\ / / _ \\ '__| | | |\r\n" +
                " | |_| | (_| | (_) | |_| |  __/ | |\\ V /  __/ |  | |_| |\r\n" +
                "  \\___/ \\__,_|\\___/|____/ \\___|_|_| \\_/ \\___|_|   \\__, |\r\n" +
                "                                                  |___/ ");












        }
    }
}