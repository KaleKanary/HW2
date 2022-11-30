//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет




namespace ConsoleApp3 
{ 
internal class Program 
    { 
    static void Main(string[] args) 
        { 
        Console.Write("Назовите мне цифру, а я скажу отдыхаем или нет  "); 
        while (true) 
            { 
            Console.Write("\n Попробуйте ввести номер дня недели  "); 
            int num = int.Parse(Console.ReadLine()); 
            if (num >= 1 && num <= 5) 
                { 
                Console.Write(" Нет, работаем"); 
                } 
 
                else if (num >= 6 && num <= 7) 
                { 
                Console.Write(" Да, отдыхаем"); 
                } 
                else Console.Write(" Мы сейчас точно о днях недели? Если да, то их всего 7"); 
            } 
        } 
    } 
}