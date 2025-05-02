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



            var moves = GetValidMoves((Piece)piece, (Move)position);

            return View(moves);
        }

        private List<string> GetValidMoves(Piece piece, Move position)
        {
            switch (piece)
            {
                case Piece.Knight:
                    return MoveKnight(position);
                case Piece.Bishop:
                    return MoveBishop(position);
                case Piece.Queen:
                    return MoveQueen(position);
                case Piece.Pawn:
                    return MovePawn(position);
                case Piece.King:
                    return MoveKing(position);
                case Piece.Rook:
                    return MoveRook(position);
                default:
                    return new List<string>();
            }
        }

        private List<string> MoveRook(Move position)
        {
            throw new NotImplementedException();
        }

        private List<string> MoveKing(Move position)
        {
            throw new NotImplementedException();
        }

        private List<string> MovePawn(Move position)
        {
            throw new NotImplementedException();
        }

        private List<string> MoveQueen(Move position)
        {
            throw new NotImplementedException();
        }

        private List<string> MoveBishop(Move position)
        {
            var validMoves = new List<string>();
            string posString = position.ToString();
            char columnChar = posString[0];
            int row = int.Parse(posString[1].ToString());
            int x = columnChar - 'A';
            int y = 8 - row;

            int[] dx = { 1, 1, -1, -1 };
            int[] dy = { 1, -1, 1, -1 };

            for (int dir = 0; dir < 4; dir++)
            {
                int newX = x + dx[dir];
                int newY = y + dy[dir];

                while (newX >= 0 && newX < 8 && newY >= 0 && newY < 8)
                {
                  
                    char col = (char)('A' + newX);
                    int rowNumber = 8 - newY;
                    validMoves.Add($"{col}{rowNumber}");

                    
                    newX += dx[dir];
                    newY += dy[dir];
                }
            }

            return validMoves;
        }


        private static List<string> MoveKnight(Move position)
        {
            var validMoves = new List<string>();

            string posString = position.ToString();
            char columnChar = posString[0];
            int row = int.Parse(posString[1].ToString());

            int x = columnChar - 'A';
            int y = 8 - row;
            

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
