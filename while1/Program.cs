//leer un numero entero y mostrar el cuadrado de sus antecesores//


int numero;


while (true)


{
    Console.WriteLine("Ingrese un numero entero: ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero.");
        Console.ResetColor();
        
    }
}
Console.WriteLine("Los cuadrados de los antecesores de " + numero + " son: ");
int cont = 1;
while (cont < numero)
{
    Console.WriteLine("el cuadrado de " + cont + " es: " + (cont * cont));
    cont++;
}