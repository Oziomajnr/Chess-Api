using System;

namespace Chess_No_Fish_Api
{
   public static class Validate_Moves
    {
       public static bool is_Valid_Move(Chess_Board board, Chess_Square source_square, Chess_Square destination_square, Pawn pawn )
        {
           if(validateGeneral(board, source_square,destination_square) == false)
           {
               return false;
           }
               //Pawn dont move backwards 
             if(pawn.color == Color.WHITE && destination_square.x < source_square.x)
             {
                    return false;
              }
             else if (pawn.color == Color.BLACK&&destination_square.x > source_square.x)
             {
                 return false;
             }
             // pawns only move one step
           if(destination_square.x - source_square.x != Math.Abs(1))
           {
               return false;
           }
            return true;
        }

       public static bool is_Valid_Move(Chess_Board board, Chess_Square source_square, Chess_Square destination_square, Rook rook)
        {

            return false;
        }

       public static bool is_Valid_Move(Chess_Board board, Chess_Square source_square, Chess_Square destination_square, Knight knight)
        {

            return false;
        }

       public static bool is_Valid_Move(Chess_Board board, Chess_Square source_square, Chess_Square destination_square, Bishop bishop)
        {

            return false;
        }

       public static bool is_Valid_Move(Chess_Board board, Chess_Square source_square, Chess_Square destination_square, Queen queen)
        {

            return false;
        }

      static bool validateGeneral(Chess_Board board, Chess_Square source_square, Chess_Square destination_square)
       {
           // you cannot move to a square containing a king, this is only possible for pawns
           if (board.Board[destination_square.x, destination_square.y] is King)
           {
               return false;
           }
          if(source_square ==  destination_square)
          {
              return false;
          }
          
          return true;
      }

      

        
    }
}
