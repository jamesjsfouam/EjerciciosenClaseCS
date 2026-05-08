int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] sumavector = new int[5];

Console.WriteLine("Ingrese los elementos del primer vector:");
for (int i = 0; i < vector1.Length; i++)
{
    Console.Write($"Elemento {i + 1}: ");
    string? input = Console.ReadLine();
    if (!int.TryParse(input, out vector1[i]))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        Console.ResetColor();
        i--; // Decrementar el índice para volver a solicitar el mismo elemento
        continue;
    }
}

Console.WriteLine("Ingrese los elementos del segundo vector:");
for (int i = 0; i < vector2.Length; i++)
{
    Console.Write($"Elemento {i + 1}: ");
    string? input = Console.ReadLine();
    if (!int.TryParse(input, out vector2[i]))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        Console.ResetColor();
        i--; // Decrementar el índice para volver a solicitar el mismo elemento
        continue;
    }
}

for (int i = 0; i < sumavector.Length; i++)
{
    sumavector[i] = vector1[i] + vector2[i];
}

for (int i = 0; i < sumavector.Length; i++)
{
    Console.WriteLine($"La suma de los elementos en la posición {i + 1} es: {sumavector[i]}");
}


