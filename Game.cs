using System; 
using System.Collections.Generic; 

namespace TicTac
{ 

	public enum Plyr
	{ 
		player1 = 1,
		player2 = 2 
	}; 

	interface Status 
	{ 

		// signatures of game state methods 
		bool IsWinner(); 

	} 
	public abstract class Game 
	{ 
		

		// Game methods, fields, board etc 
		public const int ROW = 3; 
		public const int COL = 3; 
	
		public int [,] Board = new int[ROW, COL]; 

		// Create board 
		public int [,] Create(){  
			int count = 1; 

			for(int r = 0; r < ROW; r++) { 
				for(int c = 0; c < COL; c++) { 
					Board[r,c] = count++; 
				} 
			} 

			
			return Board; 
		} 

		public void Print() 
		{ 
			for(int r = 0; r < ROW; r++) { 
				for(int c = 0 ; c < COL; c++) { 
					Console.Write($"{Board[r,c]} \t "); 
				} 
				Console.WriteLine("\n"); 
			} 
		
		} 
		

	} 

	public class Player : Game, Status 
	{ 
		// player data ie, name, x or o, etc

		private string _name; 
		public List<int> movesPlayed = new List<int>(); 
		public Dictionary<int, int [] > ChangeNumTo2D = new Dictionary<int, int [] >(); 

			

		public Player(string nm) 
		{

			this._name = nm; 
			Builder(); // adds to dictionary int position and array of row and column 
		} 

		public void Builder()
		{ 
			int count = 0; 
			int [] arr = new int[2]; 

			for(int r = 0; r < ROW; r++) { 
				for(int c = 0 ; c < COL; c++) { 
					arr[0] = r; 
					arr[1] = c; 

					ChangeNumTo2D.Add(count, arr); 
					count  += 1; 
				} 
			}  
		} 

		public void UpdateBoard(int position, Plyr p)
		{ 
			movesPlayed.Add(position); 
			Conversion(position); 
			
			Print(); 
		} 

		public void Conversion(int ps){
			int row = 0; 
			int col = 0; 
		
			row = ChangeNumTo2D[ps][0]; 
			col = ChangeNumTo2D[ps][1]; 
			
			Console.WriteLine("Line After convertion row = {0} col = {1}", row, col); 
			
		} 	
		public bool IsWinner() 
		{ 
			return false; 
		} 

	
	} 



} 
