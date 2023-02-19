// **Задача 21**
// Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними 
//в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int[] points1 = new int [3];
int[] points2 = new int [3]; 
double distance = 0;
Console.WriteLine("введите координаты 1 точки");
for (int i = 0; i < points1.Length; i++) 
    points1[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты 2 точки");
for (int i = 0; i < points2.Length; i++) 
    points2[i] = Convert.ToInt32(Console.ReadLine());

distance = Math.Sqrt(
  (points2[0] - points1[0]) * (points2[0] - points1[0]) 
+ (points2[1] - points1[1]) * (points2[1] - points1[1]) 
+ (points2[2] - points1[2]) * (points2[2] - points1[2])); 
Console.WriteLine($"расстояние между точками = {Math.Round(distance,2)}");