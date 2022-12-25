// Задача 21. Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними 
// в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetDistanceBetweenthreePoints(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double distanceBetweenthreePoints = Math.Sqrt((xB-xA)*(xB-xA) + (yB-yA)*(yB-yA) + (zB-zA)*(zB-zA));
    return distanceBetweenthreePoints;
}
int xA = 3;
int yA = 6;
int zA = 8;
int xB = 2;
int yB = 1;
int zB = -7;

double distance = GetDistanceBetweenthreePoints(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками А и В равно {distance:f}");
