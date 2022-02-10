///Показать вторую цифру трёхзначного числа.

int a = 987;
int b= a % 100;
int c = b / 10;
Console.WriteLine(c);

///Удалить вторую цифру трёхзначного числа.
int a = 987;
int b= a % 10;
int c = a / 100;
Console.WriteLine("{0} {1}", c, b);

///Найти третью цифру числа или сообщить, что её нет.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
string b = a.ToString();
Console.WriteLine(b[2]);


///Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
int mon = 1;
int tue = 2;
int wed = 3;
int thu = 4;
int fri = 5;
int sat = 6;
int sun = 7;
if (a == 6)
{
    Console.WriteLine("Выходной");
}

if (a == 7){
    Console.WriteLine("Выходной");
}
if (a < 6 && a <7 )
{
    Console.WriteLine("Не выходной");
}
