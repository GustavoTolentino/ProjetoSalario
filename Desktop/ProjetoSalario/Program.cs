using System;

namespace ProjetoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sistema de Aumento de Salario");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Para Verificar se esta apto a um aumento de salario, primeiro responda: Voce trabalha conosco?");
                string resposta = Console.ReadLine();
                    if(resposta == "sim"){
                        Console.WriteLine("Otimo, entao ensira seu salario atual:");
                        int salario = int.Parse(Console.ReadLine());
                            if(salario <= 500){
                                Console.WriteLine(salario * (30 / 100));
                                Console.ReadLine();
                            }else{
                                Console.WriteLine("Infelizmente voce nao se encaixa nos requisitos para um aumento de salario");
                            }
                    }else{
                        Console.WriteLine("Se nao trabalha conosco, nao pode receber aumento!");
                    }
        }
    }
}
