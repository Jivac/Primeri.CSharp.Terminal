using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;

			//събиране на числа
			a = 25;
			b = 7;	

			sum = a + b;

			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write (" = ");
			Console.WriteLine ( sum );

			//Допълнителни оператори
			Console.WriteLine ("\nИзползване на +=");
			a += b; // или a = a + b
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на -=");
			a -= b; // или a = a - b
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на *=");
			a *= b; // или a = a * b
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на ++");
			a++; // или a = a + 1
			Console.WriteLine ( a );

			Console.WriteLine ("Стандартно делене" + ( 14 / 4).ToString());
			Console.WriteLine ("Остатък от делене" + (14 %4).ToString ());
		}
	}
} 