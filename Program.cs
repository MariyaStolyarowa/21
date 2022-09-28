//Задача 21 Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//AB = √(xb — xa)2 + (yb — ya)2 + (zb — za)2
//Где:
//xa; ya; za — координаты первой точки,
//xb; yb; zb — координаты второй точки.
Console.Clear();
int[] A= new int[3], B= new int[3];
Console.WriteLine("Введите координаты первой точки (х, y, z): ");
for (int i=0; i<3; i++)
{A[i]=Convert.ToInt32(Console.ReadLine());}
Console.WriteLine("Введите координаты второй точки (х, y, z): ");
for (int i=0; i<3; i++)
{B[i]=Convert.ToInt32(Console.ReadLine());}
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((B[0]-A[0]), 2) + Math.Pow((B[1]-A[1]), 2) + Math.Pow((B[2]-A[2]), 2)), 2));