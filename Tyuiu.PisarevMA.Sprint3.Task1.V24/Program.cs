using Tyuiu.PisarevMA.Sprint3.Task1.V24.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 3 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                                                *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #24                                                             *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
Console.WriteLine("* по формуле                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int value = 5;
int startValue = 1;
int stopValue = 12;

Console.WriteLine("Переменная X = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));

Console.ReadKey();