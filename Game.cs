using System; 

namespace TicTac
{ 

	enum Plyr
	{ 
		player1 = 1,
		player2 = 2 

	}; 

	public interface Status 
	{ 

		// signatures of game state methods 
		public bool IsWinner(); 
		public 

	} 
	public abstract class Game 
	{ 

		// Game methods, fields, etc 

	} 

	public class Player : Game 
	{ 
		// player data ie, name, x or o, etc

		private string _name; 
		public string Name 
		{ 
			get 	
			{ 

				return this._name; 
			} 

			set
			{ 
				_name = value; 	

			} 
		} 
	
	} 



} 
