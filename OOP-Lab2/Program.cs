namespace OOP_Lab2
{
	public class Program
	{
		static void Task1()
		{
			// initializing x string variables
			string x1 = "Не кидай";
			string x2 = "вiтер";
			string x3 = "слова на марно";

			// printing x variables
			Console.WriteLine($"x1 = \"{x1}\"");
			Console.WriteLine($"x2 = \"{x2}\"");
			Console.WriteLine($"x3 = \"{x3}\"");

			// creating and printing result sentence
			string sentence = x1 + ' ' + x3.Replace("марно", x2);
			Console.WriteLine($"Result sentence: \"{sentence}\"");

			// printing length of created sentence
			Console.WriteLine($"Sentence length: {sentence.Length}");

			// printing first char of word "вітер"
			Console.WriteLine($"First char of word \"{x2}\": '{x2[0]}'");
		}

		static void Task2()
		{
			// getting input for sentence
			Console.Write("Enter sentence: ");
			string s = Console.ReadLine()!;

			// replacing all spaces in sentence on char '_' and printing the result
			string res = s.Replace(' ', '_');
			Console.WriteLine($"Result: \t{res}");
		}

		static void Main(string[] args)
		{
			// computing task 1
			Console.WriteLine("Task 1:");
			Task1();
			Console.WriteLine();

			// computing task 2
			Console.WriteLine("Task 2:");
			Task2();
			Console.ReadLine();
		}
	}
}
