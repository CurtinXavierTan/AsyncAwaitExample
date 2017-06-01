using System;
using System.Threading.Tasks;

namespace ProgramAsync {
	class Program {
		static void Main() {
			var demo = new AsyncAwaitDemo();
			demo.run();

			while (true) {
				Console.WriteLine("Doing Stuff on the Main Thread...................");
			}
		}
	}

	public class AsyncAwaitDemo {
		public async Task run() {
			await Task.Run(() =>
			{
				CountOperation();
			});
		}

		private static async Task<string> CountOperation() {
			int counter;

			for (counter = 0; counter < 100000; counter++)
			{
				Console.WriteLine(counter);
			}

			return "Counter = " + counter;
		}
	}
}
