using System; 
using System.Linq; 
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
		public string[,] Create(){  
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
		    IsWinner(); 
		} 

		public int [] Conversion(int pos){
			int [] arr = new int[2]; // will return row and col 
			int row = 0; 
			int col = 0; 
		
			row = ChangeNumTo2D[pos][0]; 
			col = ChangeNumTo2D[pos][1]; 

			arr[0] = row; 
			arr[1] = col; 

			return arr; 
		} 

		public bool IsWinner() 
		{ 
            int r = 0, c = 0; 
            // 1 - 3
            List<string> moves = new List<string>(); 
             
            while(r < Board.GetLength(0)) 
            { 
                for (int col = 0; col < Board.GetLength(1); col++) 
                { 
                    moves.Add(Board[r,col]); 
                } 
                if (moves.Distinct().Count() == 1) 
                { 
                    if (moves.Distinct().ToList()[0] != "0") 
                        return true; 
                } 
                moves.Clear(); 
                r += 1; 
            } 
            Console.WriteLine("passed 1-3"); 

            moves.Clear(); 

            // 4 - 6 
            r = 0; 
            while(r < Board.GetLength(0)) 
            { 
                for (int col = 0; col < Board.GetLength(1); col++) 
                { 
                    moves.Add(Board[col, r]);  
                } 
                 
                if (moves.Distinct().Count() == 1) 
                { 
                    if (moves.Distinct().ToList()[0] != "0")  
                        return true; 
                } 
                moves.Clear(); 
                r += 1; 
            } 

            moves.Clear(); 
            Console.WriteLine("passed 4-6"); 

            // 7 diagnol1 winning diagnol 
            for (int diagnol = 0; diagnol< Board.GetLength(0); diagnol++)
                moves.Add(Board[diagnol,diagnol]); 

            if (moves.Distinct().Count() == 1) 
            { 
                List<string> tmp = new List<string>(moves.Distinct().ToList());
                if (!tmp.Contains("0")) 
                { 
                    // return moves.Distinct().ToList()[0]; 
                    return true; 
                } 
            } 
                     
            moves.Clear(); 
            Console.WriteLine("passed 7"); 

            // 8 diagnol2 winning diagnol 
            int d = Board.GetLength(0); 

            for (int diagnol = 0; diagnol< Board.GetLength(0); diagnol++)
            { 
                d -= 1; 
                moves.Add(Board[diagnol,d]); 
            } 

            if (moves.Distinct().Count() == 1)
            { 
                List<string> tmp = new List<string>(moves.Distinct().ToList());
                if (!tmp.Contains("0")) 
                    return true; 
                    // return moves.Distinct().ToList()[0]; 
            } 

            Console.WriteLine("passed 8"); 
            /** 

            for row in Board: 
                if 0 in row: 
                    return -1 // Board not finished 
            return 0 //draw 
            **/ 
            foreach(var row in Board) 
            { 
                Console.WriteLine(row); 
            } 
            return false; 
        } 
		
		
	} 

	public class Player : Game, Status 
	{ 
		// player data ie, name, x or o, etc
		private string _p1_name; 
		private string _p2_name; 
			
		public Player(string p1, string p2) 
		{
			this._p1_name = p1; 
			this._p2_name = p2; 
			Builder(); // adds to dictionary int position and array of row and column 
		} 

	} 



} 
