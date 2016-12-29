using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_No_Fish_Api
{
   public class Rook : Chess_Pieces
    {
        public Rook(Color color)
        {
        	//initialise piece color
            this.color = color;
        }
    }
}
