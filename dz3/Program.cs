/*Задача 19  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Clear();
int i = 0;
int n = 0;
Console.WriteLine("Введите номер задачи:");
while (i == 0){
    n = Convert.ToInt32(Console.ReadLine());
    if (n > 0 & n < 4){
        break;
    }
    else {
        Console.WriteLine("Введите номер задачи, которую хотите решить:");
        Console.WriteLine("1 - проверка на полиндром:");
        Console.WriteLine("2 - расстояние между двумя точувми в 3D пространстве:");
        Console.WriteLine("3 - Таблица кубов от 1 до N:");

    }
}
if (n == 1){    //Задача 19  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.  

    void Polindron(int num){
        if((num / 10000 == num % 10) & ((num / 1000) % 10 == (num / 10) % 10) ){
            Console.WriteLine($"Число {num} --- Полиндром!!!");
        }
        else {
            Console.WriteLine($"Число {num} --- НЕ Полиндром!!!");
        }
    }
            
    while(i == 0){   
        Console.WriteLine("Введите пятизначное число");                           
        int number = Convert.ToInt32(Console.ReadLine());                                
        if (number > 9999 & number < 100000) {                               
            Polindron(number);
        }
        else {
            Console.WriteLine("Ошибка!!! Вы ввели не пятизначное число!!! "); 
        }
        Console.WriteLine("Хотите попробывать ещё раз???");
        Console.WriteLine("Введите 'да' или 'нет'");
        string test = Console.ReadLine();
        if(test.ToLower() == "да"){}
        else {break;}
    }
}

else if (n == 2){    //Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    double Rasst(double x1, double y1, double z1, double x2, double y2, double z2 )
        {
            double rasst = Math.Sqrt(Math.Pow( x2 - x1, 2)+Math.Pow(y2 - y1, 2)+Math.Pow(z2 - z1, 2));
            Console.WriteLine("rasst:" + rasst);
            return rasst;
        }

    while(i == 0){
        
        Console.WriteLine("Введите x1:");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y1:");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z1:");
        double z1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите x2:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y2:");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z2:");
        double z2 = Convert.ToDouble(Console.ReadLine());

        Rasst(x1, y1, z1, x2, y2, z2);

        Console.WriteLine("Хотите попробывать ещё раз???");
        Console.WriteLine("Введите 'да' или 'нет'");
        string test = Console.ReadLine();
        if(test.ToLower() == "да"){}
        else {break;}
    }
}

else if(n == 3){//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    
    void PowPowPow(int n){
            for(int i = 1; i <= n; i++){
            Console.WriteLine(Math.Pow(i,3));
            }
        }
    
    while(i == 0){

        Console.WriteLine("Введите Число:");
        int number = Convert.ToInt32(Console.ReadLine());
        PowPowPow(number);

        Console.WriteLine("Хотите попробывать ещё раз???");
        Console.WriteLine("Введите 'да' или 'нет'");
        string test = Console.ReadLine();
        if(test.ToLower() == "да"){}
        else {break;}
    }
}