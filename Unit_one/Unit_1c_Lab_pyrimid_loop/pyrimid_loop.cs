using System;
					
public class Program
{
	public static void Main()
	{
		int row =9;
		//Type in the row you want that is in between 1 to 9.
		int i=1;
		while (i<=row)
			{
			Console.WriteLine(i);
				i++;
				while (i>=2 && i<=row)
				{
					Console.WriteLine(i*11);
					i++;
					while (i>=3 && i<=row)
					{
						Console.WriteLine(i*111);
						i++;
						while (i>=4 && i<=row)
						{
							Console.WriteLine(i*1111);
							i++;
							while (i>=5 && i<=row)
							{
								Console.WriteLine(i*11111);
								i++;
								while (i>=6 && i<=row)
								{
									Console.WriteLine(i*111111);
									i++;
									while (i>=7 && i<=row)
									{
										Console.WriteLine(i*1111111);
										i++;
									while (i>=8 && i<=row)
										{
											Console.WriteLine(i*11111111);
											i++;
									while (i>=9 && i<=row)
											{
												Console.WriteLine(i*111111111);
												i++;
											}	
										}
									}
								}
							}
						}
					}
				}
			}
	}
}