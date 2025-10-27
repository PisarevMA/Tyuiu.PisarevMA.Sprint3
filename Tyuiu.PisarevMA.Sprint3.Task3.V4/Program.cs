using Tyuiu.PisarevMA.Sprint3.Task3.V4.Lib;
DataService ds = new DataService();
Console.Title = "Спринт 3 | Выполнил: Писарев М. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Писарев Максим Алексеевич | АСОиУб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл foreach удалить из строки все буквы j в строке           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "plkjjdw cvjkl";
char item = 'j';
Console.WriteLine($"Изначальный вид строки: {value}");
Console.WriteLine($"Буква, которая будет удалена: {item}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Полученная строка: " + ds.DeleteCharInString(value, item));

Console.ReadKey();