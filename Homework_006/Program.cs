// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите трехзначное число");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
if (stringNumber.Length > 2) {
    Console.WriteLine("Третяя цифра этого чиcла "+ stringNumber[2]);
}
else {
    Console.WriteLine("Нет третьей цифры");
}
