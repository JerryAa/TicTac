using System;
using System.Linq;
using System.Collections.Generic;

namespace TicTac 
{
    public class Test 
    { 
        public static void Main(string []args) 
        { 
            Console.WriteLine("Enter name for Player 1:"); 

			string name_p1 = Console.ReadLine(); 
			Console.WriteLine("\n"); 
			Console.WriteLine("Enter name for Player 2:"); 
			string name_p2 = Console.ReadLine(); 
			
            Game g = new Player(name_p1, name_p2); 

            g.Builder(); 
            g.Create(); 
            /** 
            **/ 
            Console.WriteLine("\n"); 
            g.Print(); 
            Console.WriteLine("\n"); 


            string stop = ""; 
            List<string> P1_moves = new List<string>();
            List<string> P2_moves = new List<string>();
            do { 

                try { 
    
                    Console.WriteLine("Player One's Turn"); 
                    Console.Write("Which position would you like:"); 
                    int pos = Convert.ToInt32(Console.ReadLine()); 
                    Console.WriteLine("\n"); 
                    
                    if (P2_moves.Contains(pos.ToString())) 
                    { 

                        Console.Write("Can't play! Spot taken"); 
                    }
                    else 
                    { 
                        P1_moves.Add(pos.ToString()); 
                    } 

                    g.UpdateBoard(pos, Plyr.player1); 

                    if(g.IsWinner() == 1) 
                    { 
                        Console.WriteLine("We have a winner!"); 
                        break; 
                    } 
                    else if (g.IsWinner() ==0) 
                    { 
                        Console.WriteLine("Draw"); 
                        break; 
                    } 


                    Console.WriteLine("Player Two's Turn"); 
                    Console.Write("Which position would you like:"); 


                    pos = Convert.ToInt32(Console.ReadLine()); 
                    Console.WriteLine("\n"); 

                    if (P1_moves.Contains(pos.ToString())) 
                    { 
                        Console.Write("Can't play! Spot taken"); 
                    }
                    else 
                    { 
                        P2_moves.Add(pos.ToString()); 
                    } 
                    g.UpdateBoard(pos, Plyr.player2); 

                    if(g.IsWinner() == 1) 
                    { 
                        Console.WriteLine("We have a winner!"); 
                        break; 
                    } 
                    else if (g.IsWinner() ==0) 
                    { 
                        Console.WriteLine("Draw"); 
                        break; 
                    } 

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

            g.Print(); 

        } 
    } 

} 
		
