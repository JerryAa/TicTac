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
			int count = 0; 

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
		public List<List<int> > ChangeNumTo2D = new List<List<int>>(); 

			

		public Player(string nm) 
		{

			this._name = nm; 
			Builder(); // adds to dictionary int position and array of row and column 
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
			Conversion(position); 
			
			// Board[r,c] = "X"; 
			// Board[r,c] = "O"; 
			Print(); 
		} 

		public void Conversion(int pos){
			int row = 0; 
			int col = 0; 
		
			/** 
			row = ChangeNumTo2D[ps][0]; 
			col = ChangeNumTo2D[ps][1]; 
			**/ 

			foreach(var x in ChangeNumTo2D[pos])  
					Console.WriteLine(x); 

			//Console.WriteLine("Line After convertion row = {0} col = {1} ", arr[0], arr[1]); 
		} 	

		public bool IsWinner() 
		{ 
			return false; 
		} 

	
	} 



} 
