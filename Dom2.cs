// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.452 -> 11 82 -> 109012 -> 12
Console.WriteLine("Inter the number");
int Sol=Convert.ToInt32(Console.ReadLine());
int sum=0;
while (Sol>0)
{
    int number=Sol%10;
    Sol=Sol/10;
    sum=sum+number;
}

Console.WriteLine(sum);
