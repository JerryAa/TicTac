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
			p1.Create(); 
			
			Console.WriteLine("Enter name for Player 2:"); 
			string name_p2 = Console.ReadLine(); 
			
			Player p2 = new Player(name_p2); 
			p2.Create(); 

			string stop = ""; 
			do { 

				try { 
					
					p1.Print(); 
					Console.WriteLine("Player One's Turn"); 
					Console.Write("Which position would you like:"); 
					int pos = Convert.ToInt32(Console.ReadLine()); 
					Console.WriteLine("\n"); 
					p1.movesPlayed.Add(pos); 
					p1.UpdateBoard(pos, Plyr.player1); 

					Console.WriteLine("Player Two's Turn"); 
					Console.Write("Which position would you like:"); 
					pos = Convert.ToInt32(Console.ReadLine()); 
					Console.WriteLine("\n"); 
					p2.UpdateBoard(pos, Plyr.player2); 
					p2.movesPlayed.Add(pos); 


					if (p1.movesPlayed.Count > 3 ||  p2.movesPlayed.Count > 3 )  
						break; 

					Console.WriteLine("\n"); 
					Console.WriteLine("Continue? Yes or No"); 
					stop = Console.ReadLine().ToLower(); 

				} 
				catch (Exception e) { 
						Console.WriteLine(e.Message); 
				} 

			} 
			while (stop.StartsWith("y")); 
			Console.WriteLine("\n"); 

        }
    }
}
