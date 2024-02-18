
ReadDirectories("C:\\Users\\DELL\\Desktop\\1");

Console.ReadKey();

static void ReadDirectories(string folderPath,int level=0)
{
    Console.SetCursorPosition(Console.CursorLeft + level, Console.CursorTop);
    Console.WriteLine($"-- {getFolderName(folderPath)}");
    string [] files =Directory.GetFiles(folderPath);
    string[] directroies = Directory.GetDirectories(folderPath);
    foreach (string file in files)
    {
        Console.SetCursorPosition(Console.CursorLeft + level, Console.CursorTop);
        Console.WriteLine($"# {Path.GetFileName(file)}");
    }
    foreach(string directoy in directroies)
    {
        ReadDirectories(directoy, level + 2);
    }
}

static string getFolderName(string folderPath)
{
    return folderPath.Split("//").Last();
}