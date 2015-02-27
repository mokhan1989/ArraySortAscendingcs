using System;
					
public class Program
{
	public static void Main()
	{
		int [] numbers = new int [] {50, 9, 45, 3};
		
		Boolean sorted = false;
		
		while(sorted == false)
		{
			sorted = true;
		
			for(int i=0; i < numbers.Length -1; i++)
			{
				
				if(numbers[i] > numbers[i+1])
				{
				
					int temp = numbers[i];
					
					numbers[i] = numbers[i+1];
					
					numbers[i+1] = temp;
					
					sorted = false;
				
				}
				
				
			}
			
			
		}
		
		for(int i = 0; i < numbers.Length; i++)
		{
			Console.WriteLine(numbers[i]);
		}
		
		//Console.WriteLine("Hello World");
	}
}