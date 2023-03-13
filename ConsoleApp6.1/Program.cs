using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {


        int[,] Matrix = new int[8, 3];
        var rows = Matrix.GetUpperBound(0) + 1;
        var cols = Matrix.Length / rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine("Y: " + i + " X:" + j);
                Matrix[i, j] = int.Parse(Console.ReadLine());


            }
        }
        Console.WriteLine();

        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < cols; x++)
            {

                Console.WriteLine(Matrix[y, x] + "\t");
            }
            Console.WriteLine() ;
        }
        double result = MyLibrary.MyLibrary.rrr(,cols);

        
        Console.WriteLine($"cреднее  арифметическое  элементов матрицы: {result}  ");
    }

}