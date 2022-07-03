/*Zadacha 19 
void Palindrom()
{
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 | number > 99999)
{
    Console.WriteLine("Число не входит в диапазон, введите 5-значное число");
}
else if (number % 10 == number / 10000 && (number % 100) / 10 == (number / 1000) % 10)
{
    Console.WriteLine("Число является палиндроном");
}
else 
{
Console.WriteLine("Число не является палиндроном");
}
}
Palindrom();
*/
/*Zadacha 19 
void Rasstoynie()
{
    int[] array1 = new int[3];
    int[] array2 = new int[3];
    for (int i = 0;i<3;i++)
    {
      Console.WriteLine("Введите координату первой точки");
      array1[i] = Convert.ToInt32(Console.ReadLine());
    }
for (int i = 0;i<3;i++)
{
    Console.WriteLine("Введите координату второй точки");
      array2[i] = Convert.ToInt32(Console.ReadLine());
}
double result = Math. Sqrt((Math.Pow((array2[0] - array1[0]), 2) + Math.Pow((array2[1] - array1[1]), 2) + Math.Pow((array2[2] - array1[2]), 2)));
result = Math.Round(result, 2);
Console.WriteLine("Расстояние между двумя точками = " + result);
}
Rasstoynie();
*/
/*Zadacha 19 */
void Kybs()
{
    Console.WriteLine("Введите число");
    int  number = Convert.ToInt32(Console.ReadLine());
    int[] array1 = new int[number];
    for (int i = 0;i<number;i++)
    {
        array1[i] = (i+1) * (i+1) * (i+1);
    }
    for (int i = 0;i<number;i++)
    {
        Console.Write (" " + array1[i]);
    }
}
Kybs();