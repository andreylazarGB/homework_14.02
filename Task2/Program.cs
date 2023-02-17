//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int index = 1;
//int Num = a % index;
int result = 0;

while ( index < a )
{
    if ( a % index > 10 )
    {
        // ???? result = a % index / index; 
        //Console.WriteLine($"Третья цифра числа: {result} ");   
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
    index = index * 10;
    //Console.WriteLine($"Третья цифра числа: {result} ");   
}
Console.WriteLine($"Третья цифра числа: {result} ");   



