using Shared;
var answer = string.Empty;

do
{
    var number = ConsoleExtension.GetInt("Introduce un numero entero");
        if (number % 2 == 0)
        {
            Console.WriteLine($"El numero {number} es par");
        }
        else
        {
            Console.WriteLine($"El numero {number} es impar");
        }

        answer = ConsoleExtension.GetValidOptions("Deseas continuar  SI Or No", new List<string> { "SI", "NO" });

} while(answer!.ToLower() == "si");
Console.WriteLine("game over ");


