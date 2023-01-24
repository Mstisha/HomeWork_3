int GetNumber(string message)
{
    int resultNumber = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число.Повторите ввод!\n");
        }
    }
    return resultNumber;
}
double getDistance(int ax, int ay, int bx, int by, int zx, int zy)
{
    double result = Math.Sqrt(Math.Pow(ax-ay,2) + Math.Pow(bx-by,2) + Math.Pow(zx-zy,2));
    return result;
}
int ax = GetNumber("Введите X координат первой точки");
int ay = GetNumber("Введите Y координат первой точки");
int bx = GetNumber("Введите X координат второй точки");
int by = GetNumber("Введите Y координат второй точки");
int zx = GetNumber("Введите X координат третей точки");
int zy = GetNumber("Введите Y координат третей точки");
double distance = getDistance(ax, ay, bx, by, zx, zy);
Console.WriteLine(distance);