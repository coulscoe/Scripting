using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		Console.WriteLine("Welcome");
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 7);
		myOperator.Compare(4,3);
		myOperator.Compare(3,4);
		myOperator.CheckPassword("Sevenof9");
		myOperator.CheckPassword("OU812");
	}
	

}

public class Operations {
		public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2){
		if(value > value2) {
			Console.WriteLine("True, the first is greater.");
		} else {
			Console.WriteLine("False, second is greater.");
		}
	}
	public void CheckPassword (string password) {
		if(password == "OU812") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");
		}
	}
}