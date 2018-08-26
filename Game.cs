using System; 
using System.Collections.Generic; 

namespace TicTac
{ 

	enum Plyr
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
		private const int ROW = 3; 
		private const int COL = 3; 
	
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


		public Player(string nm) 
		{

			this._name = nm; 
		} 

		
		public bool IsWinner() 
		{ 

			return false; 
		} 

		public List<int> movesPlayed = new List<int>(); 
	
	} 



} 
