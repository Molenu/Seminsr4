// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]6, 1, 33 -> [6, 1, 33]
int [] Bog()
{
int [] array=new int[8];
   for (int i=0; i<array.Length;i++)
   {
    Console.WriteLine("enter the array elemets");
    array[i]=Convert.ToInt32(Console.ReadLine());
   }
   return array ;
}
Console.WriteLine(string.Join(",",Bog()));
