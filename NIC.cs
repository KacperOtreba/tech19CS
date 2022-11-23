int w = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 100; i < w + 100; i++)
{
    suma += i;
}
Console.WriteLine(suma);