namespace lambda;

class Program
{
    static void Main(string[] args)
    {
        int []arr = {1,2,3,4,5,6,7,8,9};
        var squareNo = arr.Select(x => x*x);
        foreach(var x in squareNo){
            Console.WriteLine(x);
        }
    }
}
