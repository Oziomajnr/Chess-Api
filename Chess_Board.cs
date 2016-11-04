using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_No_Fish_Api
{
   public class Chess_Board
    {

       public Chess_Pieces[,] Board = new Chess_Pieces[8,8];
       
       public Chess_Board()
       {
           // initialize chess board
           Board[0, 0] = new Rook(Color.WHITE);
           Board[0, 1] = new Knight(Color.WHITE);
           Board[0, 2] = new Bishop(Color.WHITE);
           Board[0, 3] = new Queen(Color.WHITE);
           Board[0, 4] = new King(Color.WHITE);
           Board[0, 5] = new Bishop(Color.WHITE);
           Board[0, 6] = new Knight(Color.WHITE);
           Board[0, 7] = new Rook(Color.WHITE);

           Board[7, 0] = new Rook(Color.BLACK);
           Board[7, 1] = new Knight(Color.BLACK);
           Board[7, 2] = new Bishop(Color.BLACK);
           Board[7, 3] = new Queen(Color.BLACK);
           Board[7, 4] = new King(Color.BLACK);
           Board[7, 5] = new Bishop(Color.BLACK);
           Board[7, 6] = new Knight(Color.BLACK);
           Board[7, 7] = new Rook(Color.BLACK);

           Board[1, 0] = new Pawn(Color.WHITE);
           Board[1, 1] = new Pawn(Color.WHITE);
           Board[1, 2] = new Pawn(Color.WHITE);
           Board[1, 3] = new Pawn(Color.WHITE);
           Board[1, 4] = new Pawn(Color.WHITE);
           Board[1, 5] = new Pawn(Color.WHITE);
           Board[1, 6] = new Pawn(Color.WHITE);
           Board[1, 7] = new Pawn(Color.WHITE);

           Board[6, 0] = new Pawn(Color.BLACK);
           Board[6, 1] = new Pawn(Color.BLACK);
           Board[6, 2] = new Pawn(Color.BLACK);
           Board[6, 3] = new Pawn(Color.BLACK);
           Board[6, 4] = new Pawn(Color.BLACK);
           Board[6, 5] = new Pawn(Color.BLACK);
           Board[6, 6] = new Pawn(Color.BLACK);
           Board[6, 7] = new Pawn(Color.BLACK);

           //the remaining squres in the chess board is alredy empty
       }

      
    }
}
