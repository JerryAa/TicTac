using System;

namespace TicTac
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter name for Player 1:"); 

			string name_p1 = Console.ReadLine(); 
			Console.WriteLine("\n"); 
			Console.WriteLine("Enter name for Player 2:"); 
			string name_p2 = Console.ReadLine(); 
			
            Game g = new Player(name_p1, name_p2); 
            g.Create(); 
			Console.WriteLine("\n"); 
            g.Print(); 
			Console.WriteLine("\n"); 

			string stop = ""; 
			do { 

				try { 
					
					Console.WriteLine("Player One's Turn"); 
					Console.Write("Which position would you like:"); 
					int pos = Convert.ToInt32(Console.ReadLine()); 
					Console.WriteLine("\n"); 
					g.movesPlayed.Add(pos); 
					g.UpdateBoard(pos, Plyr.player1); 

					Console.WriteLine("Player Two's Turn"); 
					Console.Write("Which position would you like:"); 
					pos = Convert.ToInt32(Console.ReadLine()); 
					Console.WriteLine("\n"); 
					g.UpdateBoard(pos, Plyr.player2); 
					g.movesPlayed.Add(pos); 

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
