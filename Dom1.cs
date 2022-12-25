//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵) 2, 4 -> 16
Console.WriteLine("Inter the number A");
int A =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inter the number B");
int B =Convert.ToInt32(Console.ReadLine());
int G=A;
for (int SAD=1; SAD<B; SAD++)
{
G=G*A;
}
Console.WriteLine(G);