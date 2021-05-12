using System;

namespace ExercicioFuncao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool denovo= false;
            do
            {
            bool condicao= false;
            bool condicao2 = false;
            do
            {
            Console.WriteLine("Qual operação você deseja fazer?(soma/subt/mult/divi)");
            string operacao = Console.ReadLine();
            Console.WriteLine("Qual o primeiro número dessa operação?");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo número dessa operação?");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (operacao)
            {
                case "soma":
                    Console.WriteLine($"O resultado dessa operação é: {Soma(num1, num2)}");
                    condicao= true;
                    condicao2= false;
                    break;
                case "subt":
                    Console.WriteLine($"O resultado dessa operação é: {Subtracao(num1, num2)}");
                    condicao= true;
                    condicao2= false;
                    break;
                case "mult":
                    Console.WriteLine($"O resultado dessa operação é: {Multiplicacao(num1, num2)}");
                    condicao= true;
                    condicao2= false;
                    break;
                case "divi":
                    Console.WriteLine($"O resultado dessa operação é: {Divisao(num1, num2)}");
                    condicao= true;
                    condicao2= false;
                    break;
                default:
                    Console.WriteLine("Operação inválida, digite novamente 'soma' para somar 'subt' para subtrair 'mult' para multiplicar e 'divi' para dividir");
                    condicao= false;
                    break;
            }
            } while (condicao== false);
            do
            {
            Console.WriteLine("Deseja fazer outra operação?(s/n)");
            string resposta= Console.ReadLine();
            if(resposta=="s"){
                denovo= false;
                condicao= false;
                condicao2= true;
            } else if (resposta=="n"){
                Console.WriteLine("Tudo bem, desligando o sistema...");
                denovo= true;
                condicao= true;
                condicao2= true;
            } else{
                Console.WriteLine("Valor inválido, digite novamente 's' para sim e 'n' para não");
                condicao2= false;
            }
            } while (condicao2== false);
            } while (denovo== false);    
        }
        static double Soma(double n1, double n2){
            return n1 + n2;
        }
        static double Subtracao(double n1, double n2){
            return n1 - n2;
        }
        static double Multiplicacao(double n1, double n2){
            return n1 * n2;
        }
        static double Divisao(double n1, double n2){
            return n1 / n2;
        }
    }
}