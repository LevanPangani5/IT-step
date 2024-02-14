

ReadWrite();
static void ReadWrite()
{
    const string filePath = "C:/me/projects/sweeft/IT step/IT step/File.txt";
    char[] options = { '1', '2' };
    char option;
    ConsoleKeyInfo keyInfo = new();
    //saves users Prsonal ID before offering other functinality
    Console.WriteLine("");
    //offers user ATM funtionality
    do
    {

        Console.WriteLine("Choose coresponding number for desired functinality: ");
        Console.WriteLine("1 - Write in the File");
        Console.WriteLine("2 - Read from the file");

        option = Console.ReadKey(true).KeyChar;
        Console.Write("\n\n");
        if (!options.Contains(option))
        {
            Console.WriteLine("Invalid option try again");
            continue;
        }
        switch (option)
        {
            case '1':
                {
                    string? text = null;
                    do
                    {
                        Console.WriteLine("Enter text you want to write in the file: ");
                        text= Console.ReadLine();

                    } while (text == null);
                    Write(filePath, text);
                    break;

                }
            default:
                {
                    Reader(filePath);
                    break;
                }
        }

        Console.Write("\n\nIf you want to colse menu click tab\n click any other key to continue: ");
        keyInfo = Console.ReadKey(true);
        Console.Write("\n");
    } while (keyInfo.Key != ConsoleKey.Tab);
}
static void Write(string filePath, string text)
{
    using(StreamWriter writer = new("C:/me/projects/sweeft/IT step/IT step/File.txt", true))
    {
        writer.WriteLine(text);
    }
}

static void Reader(string filePath)
{
    using (StreamReader reader = new("C:/me/projects/sweeft/IT step/IT step/File.txt"))
    { string? line;
        Console.WriteLine("File data: ");
        while ((line=reader.ReadLine())!=null)
        {
            Console.WriteLine(line);
        }
    }
}




/*static void Write(string filePath)
{
    ConsoleKeyInfo keyInfo;
    string? sentences;
    string[] words;
    using(FileStream writer=new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
    {
        Console.WriteLine("if you ever want to exit click tab key");
        Console.WriteLine("Everything you write Will be written inside the file you specified");

        while (true)
        {
            keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Tab)
            {
                break;
            }
            sentences = Console.ReadLine();
            if(sentences != null)
            {
                words = sentences.Split(' ');

                foreach(string word in words)
                {
                    wr
                }
            }
        }

    }
}*/