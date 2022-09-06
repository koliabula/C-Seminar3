/*17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Задача */

Console.Clear();
int i = 0;
int n = 0;
Console.WriteLine("Введите номер задачи:");
while (i == 0){
    n = Convert.ToInt32(Console.ReadLine());
    if (n > 0 & n < 5){
        break;
    }
    else {
        Console.WriteLine("Введите номер задачи от 1 до 3:");
    }
}
if (n == 1){
    Console.WriteLine("Введите x:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите y:");
    int y = Convert.ToInt32(Console.ReadLine());
    

    if (x == 0 || y == 0){Console.WriteLine("x и y не должны быть равны 0");}

    else{
        if(x > 0 & y > 0)
        {
            Console.WriteLine("1 Четверть");
        }
        if(x < 0 & y > 0)
        {
            Console.WriteLine("2 Четверть");
        }
        if(x < 0 & y < 0)
        {
            Console.WriteLine("3 Четверть");
        }
        if(x > 0 & y < 0)
        {
            Console.WriteLine("4 Четверть");
        }
    }
}

if (n == 2){  //18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
    Console.WriteLine("Введите номер четверти:");
    int chet = Convert.ToInt32(Console.ReadLine());
    if(chet > 0 & chet < 5){
        if(chet == 1){
            Console.WriteLine("x > 0; y > 0");
        }
        if(chet == 2){
            Console.WriteLine("x < 0; y > 0");
        }
        if(chet == 3){
            Console.WriteLine("x < 0; y < 0");
        }
        if(chet == 4){
            Console.WriteLine("x > 0; y < 0");
        }
    }
    else {
        Console.WriteLine("Всего четыре четверти ");
    }
}


if (n == 3){
    /*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/
    double Rasst(double x1, double y1, double x2, double y2)
    {
        double rasst = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        Console.WriteLine("rasst:" + rasst);
        return rasst;
    }

    Console.WriteLine("Введите x1:");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите y1:");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите x2:");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите y2:");
    double y2 = Convert.ToDouble(Console.ReadLine());

    Rasst(x1, y1, x2, y2);
}

if (n == 4){ ///Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
    //5 -> 1, 4, 9, 16, 25.
    //2 -> 1,4

    void PowPow(int n){
        for(int i = 1; i <= n; i++){
        Console.WriteLine(Math.Pow(i,2));
        }
    }
    
    Console.WriteLine("Введите Число:");
    int number = Convert.ToInt32(Console.ReadLine());
    PowPow(number);
}

