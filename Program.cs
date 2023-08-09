
List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 66 };

for (int i = 0; i < numeros.Count; i++)
{
    Console.Write(numeros[i]+", ");
}
Console.WriteLine();
foreach (int pares in numeros)
{
    if(pares%2==0)
    {
        Console.Write($"{pares}, ");
    }
}

