using System;
					
public class Program
{
	
	public static void Main()
	{	
	int temp = 15;//type what temp it is in Celsius.
		if (temp >= 30) // typing in a tempature will show one of the for messages, each with a different level of cold or heat preparedness.
			{
				Console.WriteLine("Stay hydrated and avoid staying in the sun for too long.");
			}
			else if (temp >=20 && temp <=29)
			{
				Console.WriteLine("Enjoy the warm weather.");
			}
			else if (temp >=10 && temp <=19)
			{
				Console.WriteLine("Wear a light jacket.");
			}
			else 
			{
				Console.WriteLine("Wear warm clothing, and try to not be outside for long.");
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
			Console.WriteLine("F. Talk to your teacher, they are there to help fix this.");
		}
		
		// Type in your favorite subject. Type the corresponding number:
		// 1 is astronomy
		// 2 is english
		// 3 is biology
		// 4 is Art
		// 5 is PE
		// 6 is Math
		// the number put down will display one of 6 different subjects, each with a message on how to improve and encouragement.
			int subject = 5;
				switch (subject)
				{
					case 1:
						Console.WriteLine("Research important information, such as locations of the planets, and what the process how a star is formed. To learn of the mysteries of the universe would be very rewarding.");
						break;
					case 2: 
						Console.WriteLine("Go on the web to find what type of writing styles are there and what they do. Writing can be challenging, but rewarding.");
						break;
					case 3:
						Console.WriteLine("Study the structure of the cell, and the periodic table. There is so much we don't know about the animal kingdom.");
						break;
					case 4:
						Console.WriteLine("Look up prespective drawing, and try to imagine the art on the page. Art is such an indepth way to express thought and feeling.");
						break;
					case 5:
						Console.WriteLine("Arrive on time and prepared to workout, and try to have fun. Each of the many sports bring somthing new to the table.");
						break;
					case 6:
						Console.WriteLine("Keep practiing and explore mathimatical concepts, you can do all sorts of things with Math.");
						break;
				}
	}
}
