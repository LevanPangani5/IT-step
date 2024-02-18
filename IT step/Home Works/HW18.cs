using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Home_Works
{
    internal class HW18
    {
        static void ReadDirectories(string folderPath, int level = 0)
        {
            Console.SetCursorPosition(Console.CursorLeft + level, Console.CursorTop);
            Console.WriteLine($"-- {GetFolderName(folderPath)}");
            string[] files = Directory.GetFiles(folderPath);
            string[] directroies = Directory.GetDirectories(folderPath);
            foreach (string file in files)
            {
                Console.SetCursorPosition(Console.CursorLeft + level, Console.CursorTop);
                Console.WriteLine($"# {Path.GetFileName(file)}");
            }
            foreach (string directoy in directroies)
            {
                ReadDirectories(directoy, level + 2);
            }
        }

        static string GetFolderName(string folderPath)
        {
            return folderPath.Split("//").Last();
        }
    }
}
