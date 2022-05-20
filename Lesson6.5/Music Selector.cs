using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._5
{
    internal class Program
    {
        // В музыкальном приложении можно выбрать до 5 любимых жанров музыки
        // Данная программа берет 5 музыкальных жанров в качестве вводных данных
        // и сохраняет их в объекте MusicGenres как массив
        // Исправьте программу, указав индексатор внутри класса MusicGenres,
        // чтобы данный вывод сработал верно

        static void Main(string[] args)
        {
            MusicGenres genres = new MusicGenres();
            
            for (int i = 0; i < 5; i++)
            {
                genres[i] = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Following: " + genres[i]);
            }

            Console.ReadKey();
        }
    }

    class MusicGenres
    {
        private string[] genres = new string[5];
        public string this[int i]
        {
            get
            {
                return genres[i];
            }
            set
            {
                genres[i] = value;
            }
        }
    }
}
