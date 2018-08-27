using System;

namespace TicTac
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter name for Player 1:"); 

			string name_p1 = Console.ReadLine(); 
			Player p1 = new Player(name_p1); 
			p1.movesPlayed.Add(3); 
			
			Console.WriteLine("Enter name for Player 2:"); 
			string name_p2 = Console.ReadLine(); 
			
			Player p2 = new Player(name_p2); 
			p2.Create(); 
			Console.WriteLine("\n"); 
			p2.Print(); 
			Console.WriteLine("Which position would you like:"); 
			int pos = Convert.ToInt32(Console.ReadLine()); 
			p2.Conversion(pos); 
				
        }
    }
}
