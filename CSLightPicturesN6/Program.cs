using System;

namespace CSLightPicturesN6
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesPerLine = 7;
            int totalCountOfPictures = 52;
            int countFilledRows = totalCountOfPictures / picturesPerLine;
            int extraCountPictures = totalCountOfPictures % picturesPerLine;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Количество полностью заполненных рядов картинок: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{countFilledRows}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\nКоличество картинок не вошедших в целы ряд: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{extraCountPictures}");

            Console.ReadLine();
        }
    }
}
