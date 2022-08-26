using System;

namespace Res_Obj
{
    class Program
    {
        static void Main (String[] args)
        {
            Pessoa fulano = new Pessoa();
            fulano.setIdade(10);
            Console.WriteLine(fulano.getIdade());
        }
    }
}

/* teste para realizar quebra de linha (com split)
    string x = "nome"
    string [] y = x.Split();

    i.lenght = 2 - comentário
    x.lenght = 10 - comentário
    */


    /*using SystemIO

    arquivo date.conf consta
        ip = 255.1.1.1
        modit = server22

    string date = fileReadAllText("date.conf");
    string[] linhas = date.split("\n");
        
        foreach(string linha in linhas){
            string[]conteudos = linha.split("="),
            string key = conteudos[0],
                if(key == ip)
                    logar(conteudos[1]);
        }
    */