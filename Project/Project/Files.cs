using System;
using System.IO;
using System.Text;

namespace Project
{
  internal class Files : Menu
    {
        public static void OpenMenu()
        {
            using (FileStream fstream = File.OpenRead("menu.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(array);
                Console.WriteLine(textFromFile);
            }
        }
    }
}
