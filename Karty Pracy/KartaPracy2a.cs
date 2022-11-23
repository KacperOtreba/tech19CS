// int a, b, c, d;

// //Zad 1
// a = int.Parse(Console.ReadLine());
// b = int.Parse(Console.ReadLine());
// if ((a + b) % 2 == 0)
// {
//     Console.WriteLine("Tak");
// }
// else
// {
//     Console.WriteLine("Nie");
// }

// //Zad 2
// a = int.Parse(Console.ReadLine());
// b = int.Parse(Console.ReadLine());
// if ((a + b) / 2 > Math.Sqrt(a * b))
// {
//     Console.WriteLine("Tak");
// }
// else
// {
//     Console.WriteLine("Nie");
// }

// //Zad 3
// a = int.Parse(Console.ReadLine());
// b = int.Parse(Console.ReadLine());
// c = int.Parse(Console.ReadLine());
// if (a == b || a == c || b == c)
// {
//     Console.WriteLine("Tak");
//     if (a == b && a == c && b == c)
//     {
//         Console.WriteLine("Wszystkie liczby są takie same");
//     }
//     else if (a == b)
//     {
//         Console.WriteLine(", 1 i 2 liczba");
//     }
//     else if (a == c)
//     {
//         Console.WriteLine(", 1 i 3 liczba");
//     }
//     else if (b == c)
//     {
//         Console.WriteLine(", 2 i 3 liczba");
//     }
// }
// else
// {
//     Console.WriteLine("Nie ma takich samych liczb");
// }

// //Zad 4
// a = int.Parse(Console.ReadLine());
// b = int.Parse(Console.ReadLine());
// c = int.Parse(Console.ReadLine());
// d = int.Parse(Console.ReadLine());
// if (a < b && a < c && a < d)
// {
//     Console.WriteLine("1 liczba jest najmniejsza");
// }
// else if (b < a && b < c && b < d)
// {
//     Console.WriteLine("2 liczba jest najmniejsza");
// }
// else if (c < a && c < b && c < d)
// {
//     Console.WriteLine("3 liczba jest najmniejsza");
// }
// else if (d < a && d < b && d < c)
// {
//     Console.WriteLine("4 liczba jest najmniejsza");
// }

// //Zad 5
// a = int.Parse(Console.ReadLine());
// b = int.Parse(Console.ReadLine());
// c = int.Parse(Console.ReadLine());
// if (a + b > c && b + c > a && a + c > b)
// {
//     Console.WriteLine("Tak");
// }
// else
// {
//     Console.WriteLine("Nie");
// }

// //Zad 6
// a = int.Parse(Console.ReadLine());
// b = int.Parse(Console.ReadLine());
// c = int.Parse(Console.ReadLine());
// if (a + b > c && b + c > a && a + c > b)
// {
//     Console.WriteLine("Trójkąt powstanie");
//     if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
//     {
//         Console.WriteLine("Prostokatny");
//     }
//     else if (Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(c, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) > Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) > Math.Pow(b, 2))
//     {
//         Console.WriteLine("Ostrokatny");
//     }
//     else if (Math.Pow(a, 2) + Math.Pow(b, 2) < Math.Pow(c, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) < Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) < Math.Pow(b, 2))
//     {
//         Console.WriteLine("Rozwartokatny");
//     }
// }
// else
// {
//     Console.WriteLine("Nie ma takiego trójkąta");
// }