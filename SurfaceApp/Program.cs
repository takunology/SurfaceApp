namespace SurfaceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("面積計算アプリ");
            Console.WriteLine("1:長方形 2:三角形 3:円形");
            int num = int.Parse(Console.ReadLine());
            if(num == 1)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(Rectangle(a, b));
            }
            else if (num == 2)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(Triangle(a, b));  
            }
            else
            {
                int r = int.Parse(Console.ReadLine());
                Console.WriteLine(Circle(r));
            }
        }

        //長方形、三角形、円形
        public static int Rectangle(int a, int b)
        {
            return a * b;
        }

        public static float Triangle(int a, int b)
        {
            return a * b / 2;
        }

        public static double Circle(int r)
        {
            return r * r * Math.PI;
        }
    }
}
