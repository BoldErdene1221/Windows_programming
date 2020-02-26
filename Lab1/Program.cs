using System;
using System.IO;
using Lab1;
using Battsetseg.Labrator1;

namespace BoldErdene 
{
	namespace Lab1
	{
		class Task1
		{
			private static void Main(string[] args)
			{
				try
				{
					//ex3
					string name;
					Console.WriteLine("What is your name?");
					name = Console.ReadLine();
					if (name == "Boldoo")
						Console.WriteLine("Hi " + name + " I missed you!");
					else
						Console.WriteLine("I don't know you!!! " + name);
					//ex5
					User user = new User();
					Console.WriteLine("Name?");
					user.Name = Console.ReadLine();
					if (user.Name == "Bat")
						Console.WriteLine("LOL... U again " + user.Name);
					else
						Console.WriteLine("Hi new user " + user.Name);
					//ex6
					Age age = new Age();
					Console.WriteLine("How old are you?");
					int a = Convert.ToInt32(Console.ReadLine());
					age.SetAge(a);
					Console.WriteLine("Your age " + age.GetAge());
					Console.WriteLine("You born " + age.getYear());
				}
				catch (Exception e) {
					TextWriter errorWrite = Console.Error;
					errorWrite.WriteLine(e.Message);
				}
				
			}
		}
	}
}

