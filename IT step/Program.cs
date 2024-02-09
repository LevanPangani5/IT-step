int[] arr = new int[1000000];
Random rand = new();

for(int i =0; i < arr.Length; i++)
{
    arr[i] = rand.Next(10000,99999);
}

var palindrome = arr.Where(x => isPalindrome(x)).ToArray();

for(int i=0; i < 10; i++)
{
    Console.WriteLine(palindrome[i]);
}

 static bool isPalindrome(int numb)
{
    string data = numb.ToString();
    int startI = 0;
    int endI = data.Length - 1;
    while (startI < data.Length / 2)
    {
        if(data[startI] != data[endI])
        {
            return false;
        }
        startI++;
        endI--;
    }
    return true;
}
