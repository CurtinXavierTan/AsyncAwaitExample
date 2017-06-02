using System;
using System.Threading.Tasks;

namespace ProgramAsync {
    
	class Program {
        
		static void Main() {
            
            //Create an instance that run async method
			var demo = new AsyncAwaitDemo();
			demo.run();

            //Infinite loop to show that both are running at the same time
			while (true) {
				Console.WriteLine("Doing Stuff on the Main Thread...................");
			}
		}
	}

    /* Method that runs the count operation asynchronously */

	public class AsyncAwaitDemo {
		public async Task run() {
            
            //Run with async here
			await Task.Run(() =>
			{
				CountOperation();
			});
		}

        /* Count method - counting from 0 to 100000, and print number out */
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
