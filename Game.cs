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

			for(int r = 0; r < ROW; r++) { 
				for(int c = 0; c < COL; c++) { 
					Board[r,c] = 0; 
				} 
			} 
			
			return Board; 
		} 

		public void Print() 
		{ 
			foreach(var x in Board){ 
				Console.WriteLine(x); 
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
		} 

		public void Builder()
		{ 
			int count = 0; 

			for(int r = 0; r < ROW; r++) { 
				for(int c = 0 ; c < COL; c++) { 
					// ChangeNumTo2D.Add(count, [r,c]); 
					count  += 1; 
				} 
			}  
		} 

		public void UpdateBoard(int position, Plyr p)
		{ 
			Conversion(position); 
			
			Print(); 
		} 

		public void Conversion(int ps){
			// ChangeNumTo2D.Add(
			
		} 	
		public bool IsWinner() 
		{ 
			return false; 
		} 

	
	} 



} 
