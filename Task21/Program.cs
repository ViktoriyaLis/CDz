//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int getUserValue (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double getDistanseCoordinat(int userAx, int userAy, int userBx, int userBy, int userCx, int userCy)
{
    double result = Math.Sqrt(Math.Pow((userAx-userBx-userCx),2) + Math.Pow((userAy-userBy-userCy),2));
    return result;
}

int userAx = getUserValue("Введите X");
int userAy = getUserValue("Введите Y");
int userBx = getUserValue("Введите X");
int userBy = getUserValue("Введите Y");
int userCx = getUserValue("Введите X");
int userCy = getUserValue("Введите Y");

double distanse = getDistanseCoordinat(userAx,userAy,userBx,userBy,userCx,userCy);
Console.WriteLine($"Расстояние = {Math.Round(distanse,2)}");


