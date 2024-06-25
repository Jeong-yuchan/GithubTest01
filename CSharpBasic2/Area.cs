
namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("가로를 입력하세요 : ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("세로를 입력하세요 : ");
            int height = int.Parse(Console.ReadLine());

            double result = (width * height)/2.0; // 수식
            
            Console.WriteLine($"넓이는 {result} 입니다.");
            
        }
    }
}
