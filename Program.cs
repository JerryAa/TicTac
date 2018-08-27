using System;

namespace TicTac
{
    class Program
    {
        static void Main(string[] args)
        {
			var val = Plyr.player1; 	
			Console.WriteLine($"{val}"); 

			Console.WriteLine("Enter name for Player 1:"); 

			string name_p1 = Console.ReadLine(); 
			Player p1 = new Player(name_p1); 
			p1.Create(); 
			// p1.movesPlayed.Add(3); 
			
			Console.WriteLine("Enter name for Player 2:"); 
			string name_p2 = Console.ReadLine(); 
			
			Player p2 = new Player(name_p2); 
			p2.Create(); 

			do { 

				try { 
					
					p1.Print(); 
					Console.WriteLine("Player One's Turn"); 
					Console.WriteLine("Which position would you like:"); 
					int pos = Convert.ToInt32(Console.ReadLine()); 
					Console.WriteLine("\n"); 
					p1.UpdateBoard(pos); 

					Console.WriteLine("Player Two's Turn"); 
					Console.WriteLine("Which position would you like:"); 
					pos = Convert.ToInt32(Console.ReadLine()); 
					Console.WriteLine("\n"); 
					p2.UpdateBoard(pos); 

					Console.WriteLine("\n"); 
					Console.WriteLine("Continue? Yes or No"); 
					string stop = Console.ReadLine(); 


				} 
				catch (Exception e) { 
						Console.WriteLine(e.Message); 
				} 
			} 
			while (stop.Equals("Yes")); 

			Console.WriteLine("\n"); 

        }
    }
}
