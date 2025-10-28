using Tyuiu.PisarevMA.Sprint3.Task6.V9.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 3 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
Console.WriteLine("* числовому отрезку [19, 30], количество всех делителей                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = 19;
int stopValue = 30;

Console.WriteLine(" = " + startValue);
Console.WriteLine(" = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Количество = " + ds.GetSumTheDivisors(startValue, stopValue)); 

Console.ReadKey();