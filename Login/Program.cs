using System;
using System.IO;
using System.Security.Cryptography;

namespace Login
{
    class Program
    {
        //hash é converter uma string em número
        static bool cadastrar(string username, string password)
        {
            string linha = username + "=" + password;

            File.AppendAllText("users.txt", linha);
        } //Finalizar código de criptografia
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem vindo!");
            System.Console.WriteLine("Digite 1 para logar");
            System.Console.WriteLine("Digite 2 para cadastrar");
            System.Console.WriteLine("Digite 3 para sair");

            bool sair = false;
            while (!sair)
            {
                int opcao = 0;
                try{
                    opcao = int.Parse(Console.ReadLine());
                }
                catch(Exception )
                {
                    //nada
                    //Poderia colocar a mensagem de erro aqui caso não valide no switch
                }
                
                switch(opcao)
                {
                    case 1:
                        //TODO logar
                        break;
                    case 2:
                        Console.WriteLine("Digite um nome de usuário");
                        string username = Console.ReadLine();
                        Console.WriteLine("Digite uma senha");
                        string password = Console.ReadLine();
                        Console.WriteLine("Confirme a senha");
                        string confirm = Console.ReadLine();
                        if(password != confirm)
                        {
                            Console.WriteLine("as senhas não coincidem, tente novamente!");
                        }
                        else
                        {
                            if (cadastrar(username, password))
                            {
                                Console.WriteLine("Cadastro efetuado!");
                            }
                            else
                            {
                                Console.WriteLine("Tente cadastrar novamente!");
                            }
                        }
                        //TODO cadastrar
                        break;
                    case 3:
                        sair = true; 
                        //TODO sair
                        break;
                    case 4:
                        //TODO opção inválida
                        break;
                    default : Console.WriteLine("Opção inválida, tente novamente!");
                }
            }
        }
    }
}
