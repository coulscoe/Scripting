using System;
					
public class Program
{
	public void Main()
	{
			string [] cars = {"Mustang","Camero","Hellcat", "Corvette", "Viper", "McClerean"};
			Console.WriteLine(cars.Length);
			Console.WriteLine(cars[0]);
			foreach (var car in cars)
			{
				Console.WriteLine("I love my " + car + ",");
			}
		
					string[] playerTypes = {"Pawn", "Pawn", "Pawn"};
		
					for (var i = 0; i < playerTypes.Length ; i++) {
						playerTypes [i] = "Queen";
					}
					
					foreach(var playerType in playerTypes) {
						Console.WriteLine(playerType);
					}
	}
}