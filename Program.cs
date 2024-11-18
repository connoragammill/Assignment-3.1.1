using System.Text;

namespace Assignment_3._1._1._
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string evenNumbers = EvenNumbers(); 
			Console.WriteLine(evenNumbers);
		}
		static string EvenNumbers()
		{
			StringBuilder sb = new StringBuilder(); 
			for (int i = 2; i < 100; i += 2) 
			{
				sb.Append(i);
				sb.Append(" "); 
			}

			return sb.ToString();

		}
    }
}
