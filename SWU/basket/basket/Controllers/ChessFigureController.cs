using Microsoft.AspNetCore.Mvc;

namespace basket.Controllers
{
    public class ChessFigureController : Controller
    {
        public IActionResult validateMove(Move? position, Piece? piece)
        {
            if (position is null || piece is null)
            {
                return View(null);
            }

           

            var moves = GetValidMoves((Piece)position, (Move)piece);
            return View(moves);
        }

        private List<string> GetValidMoves(Piece piece, Move position)
        {
            var validMoves = new List<string>();

            if (piece != Piece.Knight)
            {
                return validMoves;
            }


            string posString = position.ToString();  
            char columnChar = posString[0];          
            int row = int.Parse(posString[1].ToString());

            int x = columnChar - 'A';  
            int y = 8 - row;          
            ;

            int[,] moves = new int[,]
            {
        { -2, -1 }, { -2, 1 }, { -1, -2 }, { -1, 2 },
        { 1, -2 }, { 1, 2 }, { 2, -1 }, { 2, 1 }
            };

            for (int i = 0; i < moves.GetLength(0); i++)
            {
                int newX = x + moves[i, 0];
                int newY = y + moves[i, 1];

                if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8)
                {
                    char col = (char)('A' + newX);
                    int rowNumber = 8 - newY;
                    validMoves.Add($"{col}{rowNumber}");
                }
            }
            return validMoves;
        }
    }
}
