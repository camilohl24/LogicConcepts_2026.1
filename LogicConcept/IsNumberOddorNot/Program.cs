var numberString = string.Empty;
do
{
    Console.WriteLine("Ingrese un numero o presiona la palabra salir");
    numberString = Console.ReadLine();
    var numberInt = 0;
    if (numberString.ToLower() == "salir")
    {
        continue;
    }
    if( int.TryParse(numberString,  out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El numero {numberInt} es par");
        }
        else
        {
            Console.WriteLine($"El numero {numberInt} es impar");
        }

    }
    else
    {
        Console.WriteLine($"El numero {numberString} no es un numero entero");
    }


} while(numberString.ToLower() != "salir");
Console.WriteLine("game over ");


