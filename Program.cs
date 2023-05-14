class Program
{
    static void Main(string[] args)
    {
        // Создаем исходный массив строк
        string[] array = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

        // Создаем новый массив строк
        string[] newArray = new string[array.Length];

        // Индекс для нового массива
        int index = 0;

        // Проходим по каждой строке в исходном массиве
        for (int i = 0; i < array.Length; i++)
        {
            // Проверяем длину строки
            if (array[i].Length <= 3)
            {
                // Добавляем строку в новый массив
                newArray[index] = array[i];
                index++;
            }
        }
Console.WriteLine("Новый массив:");
Console.WriteLine($"[{string.Join(", ", array)}]");


        // Выводим новый массив строк на экран
        Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам:");
        for (int i = 0; i < index; i++)
        {
            
            Console.WriteLine(newArray[i]);
        }
       
    }
}