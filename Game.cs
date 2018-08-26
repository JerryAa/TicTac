using System; 

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

		// Game methods, fields, etc 

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
	
	} 



} 
