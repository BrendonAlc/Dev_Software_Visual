using System; //System também é um namespace

namespace Projeto_01 //namespace utilizado para conter o nome do projeto
{
    class Program //Funções somente pode ser declarada dentro da classe
    // Classe é uma struct
    //Variável deve ser declarado dentro de uma função de uma classe

    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe a largura: ");
                //double area = CalculaArea(35.0, 3.0);
                //Console.WriteLine(area);
                //string largura = Console.ReadLine();
                double largura = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine(largura);

                Console.WriteLine("Informe a altura: ");
                //string altura = Console.ReadLine();
                double altura = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine(altura);
                
                
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                throw;
            }
            
        }

        double area = CalculaArea(largura,altura);
            Console.WriteLine("A área equivale a : " + area);
            //Console.WriteLine(area);
        static double CalculaArea(double largura, double altura)
        {
            //double area = largura * altura;
            return largura * altura;
        }
    }
}


//programa que retorna com sucesso retorna 0 ao final do código (return 0)

//camelCase somente para atributos
//PascalCase para classes e módulos
//snake_case para métodos, variáveis, nomear arquivos
//SNAKE_CASE modo de escrita para informar macro.

//***Exemplos de nomenclaturas***

// Camel_case	primeiroNomePessoa
// Pascal_case	PrimeiroNomePessoa
// Snake_case	primeiro_nome_pessoa
// Screaming_snake_case	PRIMEIRO_NOME_PESSOA
// Kebab_case	primeiro-nome-pessoa
// Screaming_kebab_case	PRIMEIRO-NOME-PESSOA