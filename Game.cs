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
	
		public string[,] Board = new string [ROW, COL]; 

		public List<int> movesPlayed = new List<int>(); 
		public List<List<int> > ChangeNumTo2D = new List<List<int>>(); 

		// Create board 
		public string [,] Create(){  
			int count = 0; 

			for(int r = 0; r < ROW; r++) { 
				for(int c = 0; c < COL; c++) { 
					Board[r,c] = count.ToString(); 
					count += 1; 
				} 
			} 

			
			return Board; 
		} 

		public void Print() 
		// print board 
		{ 
			for(int r = 0; r < ROW; r++) { 
				for(int c = 0 ; c < COL; c++) { 
					Console.Write($"{Board[r,c]} \t "); 
				} 
				Console.WriteLine("\n"); 
			} 
			Console.WriteLine("\n"); 


			foreach (var x in movesPlayed) { 
				Console.WriteLine(x); 
			} 
		
		} 

		public void Builder()
		{ 
			List<int [] > temp = new List< int [] >(); 
			List<int> arr = new List<int>(3); 	

			for(int r = 0; r < ROW; r++) { 
				for(int c = 0 ; c < COL; c++) { 
					arr.Add(r); 	
					arr.Add(c); 	
					ChangeNumTo2D.Add(arr); 
					arr = new List<int>();  //reset 
				} 
			}  
		} 

		public void UpdateBoard(int position, Plyr p)
		{ 
			movesPlayed.Add(position); 
			int [] location = Conversion(position); 

			int player = (int) p; 	

			if (player == 1) { 
				Board[location[0], location[1]] = "[X]"; 
			} 
			else if (player == 2) { 
				Board[location[0], location[1]] = "[0]"; 
			} 

			Print(); 
		} 

		public int [] Conversion(int pos){
			int [] arr = new int[2]; // will return row and col 
			int row = 0; 
			int col = 0; 
		
			row = ChangeNumTo2D[pos][0]; 
			col = ChangeNumTo2D[pos][1]; 

			// Console.WriteLine("Line After Conversion row = {0} col = {1} ", row, col);  
			
			arr[0] = row; 
			arr[1] = col; 

			return arr; 
		} 	
		

	} 

	public class Player : Game, Status 
	{ 
		// player data ie, name, x or o, etc
		private string _name; 
			
		public Player(string nm) 
		{
			this._name = nm; 
			Builder(); // adds to dictionary int position and array of row and column 
		} 

		public bool IsWinner() 
		{ 
			return false; 
		} 

	
	} 



} 
