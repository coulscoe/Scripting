using System;
					
public class Program
{
	public static void Main()
	{	
		
	int temp = 40;//type what temp it is in Celsius.
		if (temp >= 30) // if the temperature is greater then or equal to 30, then the text, "Stay hydrated and avoid staying in the sun for too long." displayies. 
			{
				Console.WriteLine("Stay hydrated and avoid staying in the sun for too long.");
			}
			else //if the temperature is not greater then or equal to 30, then the text "Enjoy the pleasant weather." will show.
			{
				Console.WriteLine("Enjoy the pleasant weather.");
			}
		
	int grade =80;//type in a grade as a precentage
		if (grade >=90) //if the grade is greater then 90, then an A shows.
		{
			Console.WriteLine("A. Keep up the amazing work.");
		}
		else if (grade<=89 && grade>=80)//otherwise if grade is between 89-90 then B shows. 
		{
			Console.WriteLine("B. Keep going, your doing great.");
		}
		else if (grade<=79 && grade>=70)//if not, and if grade is between 79-70 then C shows. 
		{
			Console.WriteLine("C. You got this, make sure to not get behind.");
		}
		else if (grade<=69 && grade>=51)//if not those, and grade is between 69-51, then D shows. 
		{
			Console.WriteLine("D. You should get some extra assistence. You got this.");
		}
		else //if the number does not meet those requirements, then F shows.
		{
			Console.WriteLine("F. Talk to your teacher, they are there to help you get through this.");
		}
	}
}
