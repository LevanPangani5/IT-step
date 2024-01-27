

DisplayDelegate del = new(dispalyCalcResult);
MyCalculator myCalc = new();
myCalc.Add(5, 7, del);
myCalc.Subtract(5, 7, del);
myCalc.Multiplay(5, 7, del);
myCalc.Devide(5, 7, del);



static void dispalyCalcResult(double x, double y, char action, double result)
{
    Console.WriteLine($"{x} {action} {y}= {result}");
}




public delegate void DisplayDelegate(double x, double y,char action , double result);

public class MyCalculator
{
    public void Add(double x, double y, DisplayDelegate del)
    {
        double result = x * y;
        del(x, y, '+', result);

    }
    public void Subtract(double x, double y, DisplayDelegate del)
    {
        double result = x - y;
        del(x, y, '-', result);
    }
    public void Multiplay(double x, double y, DisplayDelegate del)
    {
        double result = x * y;
        del(x,y,'*', result);
    }
    public void Devide(double x, double y, DisplayDelegate del) 
    {
        double result = x / y;
        del(x,y,'/', result);
    }
}
