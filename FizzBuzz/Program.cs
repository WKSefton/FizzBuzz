using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz {
	class Program {
		static void Main(string[] args) {
			for (int i = 1; i <= 100; i++) {

				Console.WriteLine((i % 15 == 0) ? "Fizz Buzz" : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : $"{i}");

			}
		}
	}
}
