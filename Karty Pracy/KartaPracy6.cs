// 1.
/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (b - a == c - b) Console.WriteLine("Jest arytmetyczny");
if (b / a == c / b) Console.WriteLine("Jest geometryczny");
if (a > b && b > c) Console.WriteLine("Jest Rosnący"); 
else Console.WriteLine("Jest malejacy");
*/

// 2. (Easy) Oblicz sumę liczb trzycyfrowych podzielnych przez 8 i niepodzielnych przez 16
/*
Console.WriteLine("Zadanie 2");
int suma = 0;
for (int i = 100; i < 1000; i++)
{
    if (i % 8 == 0 && i % 16 != 0)
    {
        suma += i;
    }
}
Console.Write(suma + " ");
*/
// 3. (Easy) Oblicz ilość liczb cztrocyfrowych będącymi wielokrotnościami największej liczby dwucyfrowej podzielnej przez 7. 
//           Wielokrotność, będącą podstawą rozwiązania tego zadania, znajdź za pomocą pętli
/*Console.WriteLine("Zadanie 3");
int podzielnik = 0;
for (int i = 99; i > 9; i--)
{
    if (i % 7 == 0)
    {
        podzielnik = i;
        break;
    }
}

int suma = 0;
for (int j = 1000; j < 10000; j++)
{
    if (j % podzielnik == 0)
    {
        suma += j;
    }
}
Console.WriteLine(suma);
*/
// 4. (Medium) Oblicz ilość liczb dwucyfrowych, w kórych cyfra dziesiątek jest przynajmniej dwa razy większa
//             od cyfry jedności
/*Console.WriteLine("Zadanie 4");
int iloscliczb = 0;
for (int i = 10; i <= 99; i++)
{
    int dzie = i / 10;
    int jedn = i % 10;
    if (dzie >= jedn * 2)
    {
        iloscliczb++;
    }
}
Console.WriteLine($"Ilość tych liczb to: {iloscliczb}");
*/
// 5. (Medium) Oblicz sumę i ilość liczb trzycyfrowych, w których cyfra setek jest większa od sumy cyfr dziesiątek i jedności
/*Console.WriteLine("Zadanie 5");
int suma = 0;
int ilosc = 0;
int cyfrasetek = 0;
int cyfradziesiatek = 0;
int cyfrajednosci = 0;
int sumacyfridziesiatek = 0;
for (int i = 100; i < 1000; i++)
{
    cyfrasetek = i / 100;
    cyfradziesiatek = i % 100 / 10;
    cyfrajednosci = i % 10;
    sumacyfridziesiatek = cyfrajednosci + cyfradziesiatek;
    if (cyfrasetek > sumacyfridziesiatek)
    {
        suma += i;
        ilosc += 1;
    }
}
Console.WriteLine($"Suma to: {suma}");
Console.WriteLine($"Ilosc to: {ilosc}");
*/
// 6. (Medium) Oblicz sumę n najmniejszych liczb dwucyfowych podzielnych przez 19
/*Console.WriteLine("Zadanie 6");
int n = int.Parse(Console.ReadLine());
int suma = 0;
int ilosc = 0;
for (int i = 10; i < 100; i++)
{
    if (i % 19 == 0)
    {
        suma += i;
        ilosc++;
    }
    if (ilosc == n)
    {
        Console.WriteLine(suma);
        break;
    }
    if (i == 99)
    {
        Console.WriteLine("OUT OF RANGE");
    }
}
*/
// 7.  (Medium) Oblicz sumę n największych liczb trzycyfrowych podzielnych przez 37
/*Console.WriteLine("Zadanie 7");
int n = int.Parse(Console.ReadLine());
int suma = 0;
int skladnik = 0;
for (int j = 999; j > 100; j--)
{
    if (j % 37 == 0)
    {
        skladnik = j;
        break;
    }
}
for (int i = 0; i < n; i++)
{
    suma += (skladnik - 37 * i);
}
Console.WriteLine(suma);
*/
// 8.  (Medium) Ciąg skaczący. Oblicz sumę n pierwszych elementów poniższego ciągu:
//              2 − 5 + 8 − 11 + 14 − 17 + 20 − ...
/*int n = Convert.ToInt32(Console.ReadLine());
int rytm = 2;
int suma = 0;

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        suma += rytm;
    }
    else
    {
        rytm *= -1;
        suma += rytm;
        rytm *= -1;

    }
    rytm += 3;
}
Console.WriteLine(suma);*/
// 9.(Medium) Ciag zakrecony. Oblicz iloczyn n pierwszych elementów ponizszego ciagu:
//   1 * (-2) * 4 * (-8) * 16 * (-32)  ...
/*int n = Convert.ToInt32(Console.ReadLine());
int iloczyn = 1;
int rytm = 2;

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        iloczyn *= rytm;
    }
    else
    {
        rytm *= -1;
        iloczyn *= rytm;
        rytm *= -1;
    }
    rytm *= 2;
}
*/
// 10. (Hard) Ciąg siłaczy.Oblicz sumę n pierwszych elementów poniższego ciągu
//      1! + 2! + 3! + 4! + 5! + ...
/*int n = Convert.ToInt32(Console.ReadLine());
int suma = 0;
int silnia = 1;

for (int i = 2; i < n+2; i++)
{
    suma += silnia;
    silnia *= i;
}
Console.WriteLine(suma);
*/

// 11. (Hard) Ciąg niebanalny1. Napisz program, który obliczy sumę n ułamków następującej postaci
/*int n = Convert.ToInt32(Console.ReadLine());
int suma = 0;
int licznik = 1;
int mianownik = 1;

for (int i = 0; i < n; i++)
{
    suma += licznik / mianownik;
    licznik += 2;
    mianownik += licznik;
}
Console.WriteLine(suma);
*/
// 12. (Hard) Ciąg niebanalny2. Napisz program, który obliczy ułamek n elementów licznika
//     i mianownika następującej postaci
/*int n = Convert.ToInt32(Console.ReadLine());
int licznik = 0;
int mianownik = 0;
int ciaggora = 1;
int ciagdol = 1;

for (int i = 0; i < n; i++)
{
    licznik += ciaggora;
    mianownik += ciagdol;
    ciaggora += 2;
    ciagdol += ciaggora;
}
Console.WriteLine(licznik/mianownik);
*/
// 13. (Hard) Ciąg wymagający. Napisz program, który obliczy sumę n ułamków następującej postaci
/*int n = Convert.ToInt32(Console.ReadLine());
float suma = 0;
int licznik = 2;
int mianownik = 3;

for (int i = 0; i < n; i++)
{
    suma = (float)licznik / mianownik;
    licznik += 2;
    mianownik = (int)Math.Pow(i, 3) + 2;
}
Console.WriteLine(suma);
*/
// 15. (Hard) Ciąg totalny. Napisz program, który obliczy iloczyn n ułamków następującej postaci
/*int n = Convert.ToInt32(Console.ReadLine());
int licznik = 1;
int mianownik = 1;
int ciaggora = 3;
int ciagdol = 1;
for (int i = 0; i < n; i++)
{
    licznik *= ciaggora;
    mianownik *= ciagdol;
    ciaggora++;
    ciagdol = (ciagdol * 2) + 1;
}
Console.WriteLine((float)licznik/mianownik);*/

// 16. (Hard) Ciąg ekstremalny. Napisz program, który obliczy iloczyn n ułamków następującej postaci
/*int n = Convert.ToInt32(Console.ReadLine());
float licznik = 1;
float mianownik = 1;
int ciaggora = 1;
int ciagdol= 1;
int fib1 = 1;
int fib2 = 1;
int sumafib = 0;

for (int i = 0; i < n; i++)
{
    licznik *= (float)ciaggora;
    mianownik *= ciagdol;
    sumafib = fib1 + fib2;
    fib1 = fib2;
    fib2 = sumafib;
    ciaggora = sumafib;
    ciagdol *= 2;
}
Console.WriteLine(licznik/mianownik);*/
