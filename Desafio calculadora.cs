using System;

public class Calculadora
{
    public static void Main()
    {

        int num1 = 0; int num2 = 0;
        int escolha;

        
        Console.Clear();
        Console.WriteLine("\n\tCalculadora\r");
        Console.WriteLine("------------------------------\n");


        Console.WriteLine("Escreva o primeiro número: ");
        num1 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Escreva o segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Escolha algum dos numeros da opção na lista a seguir: ");
        Console.WriteLine("\n=================================");
        Console.WriteLine("|" + "\t1 -> a + Adição" + "\t\t|");
        Console.WriteLine("|" + "\t2 -> s - Subtração" + "\t|");
        Console.WriteLine("|" + "\t3 -> m * Multiplicação" + "\t|");
        Console.WriteLine("|" + "\t4 -> d / Divisão" + "\t|");
        Console.WriteLine("|" + "\t5 -> r / Resto divisão" + "\t|");
        Console.WriteLine("|" + "\t6 -> p / Potenciação" + "\t|");
        Console.WriteLine("|" + "\t0 -> s ~ Sair" + "\t\t|");
        Console.WriteLine("=================================");
        Console.Write("\nQual sua escolha? ");
        escolha = Convert.ToInt32(Console.ReadLine());
        if (escolha == 1 || escolha == 2 || escolha == 3 || escolha == 4 || escolha == 5 || escolha == 6 || escolha == 0)
        {
        switch (escolha)
        {
            case 1:
                Console.WriteLine($"Seu resultado foi: {num1} + {num2} = " + (num1 + num2));
                    Console.ReadLine(); 
                    Main();
                break;
            case 2:
                Console.WriteLine($"Seu resultado foi: {num1} - {num2} = " + (num1 - num2));
                    Console.ReadLine();
                    Main();
                break;
            case 3:
                Console.WriteLine($"Seu resultado foi: {num1} * {num2} = " + (num1 * num2));
                    Console.ReadLine();
                    Main();
                break;
            case 4:
                    while (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero, escolha outro número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Seu resultado foi: {num1} / {num2} = " + (num1 / num2));
                    Console.ReadLine();
                    Main();
                break;
            case 5:
                Console.WriteLine($"Seu resultado foi: {num1} % {num2} = " + (num1 % num2));
                    Console.ReadLine();
                    Main();
                break;
            case 6:
                double cont = Math.Pow(num1, num2);
                Console.WriteLine($"Seu resultado foi: {num1} * {num2} = " + cont);
                    Console.ReadLine();
                    Main();
                break;
            case 0:
                Console.Clear();
                Console.WriteLine($"Adeus, tenha um bom dia.");
                break;
        }
 
        }
        else
        {
            Console.Clear();
            Console.WriteLine("====================================================================");
            Console.WriteLine("Aguarde alguns segundos e tente novamente e digite uma opção válida");
            Console.WriteLine("====================================================================\n");
            Thread.Sleep(4600);
            Main();
        }
        Console.WriteLine("Pressione qualquer tecla para sair...");
    }
}