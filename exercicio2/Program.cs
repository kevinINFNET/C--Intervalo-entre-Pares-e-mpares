using System;

class Programa
{
    static void Main()
    {
        int inferior = LerIntervalo("inferior");
        int superior = LerIntervalo("superior", inferior);

        int somaPares = CalcularSomaPares(inferior, superior);
        int somaImpares = CalcularSomaImpares(inferior, superior);

        Console.WriteLine($"Soma de pares = {somaPares}");
        Console.WriteLine($"Soma dos ímpares = {somaImpares}");
    }

    static int LerIntervalo(string descricao, int limiteInferior = int.MinValue)
    {
        int valor;
        while (true)
        {
            Console.Write($"Entre com intervalo {descricao}: ");
            if (int.TryParse(Console.ReadLine(), out valor) && valor > 0 && (descricao == "inferior" || valor > limiteInferior))
            {
                break;
            }
            Console.WriteLine($"Valor inválido. O intervalo {descricao} deve ser maior que {(descricao == "inferior" ? "zero" : limiteInferior.ToString())}.");
        }
        return valor;
    }

    static int CalcularSomaPares(int inferior, int superior)
    {
        int soma = 0;
        for (int i = inferior; i <= superior; i++)
        {
            if (i % 2 == 0)
            {
                soma += i;
            }
        }
        return soma;
    }

    static int CalcularSomaImpares(int inferior, int superior)
    {
        int soma = 0;
        for (int i = inferior; i <= superior; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }
        return soma;
    }
}

