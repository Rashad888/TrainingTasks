using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakfast
{
	class Program
	{
		static void Main(string[] args)
		{
			var tasks = new Func<Task>[]
				{
					() => CutMushRoomAsync(5),
					() => FryBreadSlicesAsync(2),
					() => FryEggsAsync(2)
				};
			Console.WriteLine("Cooking breakfast is started!");
			GetTasksAsync(tasks);
			Console.WriteLine("Cooking breakfast is started!");
			Console.ReadLine();
		}

		static async void GetTasksAsync(Func<Task>[] tasks) 
		{
			await Task.WhenAll(tasks.Select(task => task()).ToArray());
		}

		static async Task CutMushRoomAsync(int numOfMushRooms) 
		{
			await Task.Run(() => 
			{
				Console.WriteLine("Cutting mushRooms");
			});
			FryMushRoom();
		}

		static void FryMushRoom()
		{
			Console.WriteLine("Frying mushrooms");
		}

		static async Task FryBreadSlicesAsync(int numOfSlices) 
		{
			await Task.Run(() =>
			{
				Console.WriteLine($"Frying {numOfSlices} bread slices");
			});
		}

		static async Task FryEggsAsync(int numEggs)
		{
			await Task.Run(() =>
			{
				Console.WriteLine($"Frying {numEggs} eggs");
			});
		}
	}
}
