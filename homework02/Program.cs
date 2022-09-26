// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Console.WriteLine("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Имеем число! "); 
Console.WriteLine(number); 
if (Convert.ToString(number).Length < 3) 
{
     Console.WriteLine("Нет третьего числа");
} 
else
 { 
    char[] 
    line = Convert.ToString(number).ToCharArray(); 
    Console.WriteLine("Третье число: "); 
    Console.Write(line[2]); 
    }
