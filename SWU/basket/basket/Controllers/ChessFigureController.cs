using basket.Enums;
using basket.Models;
using Microsoft.AspNetCore.Mvc;

namespace basket.Controllers
{
    public class ChessFigureController : Controller
    {
        public IActionResult Index()
        {
            var m=new ChessViewModel { Request = new PieceRequest(), Response = null };
            return View(m);
        }

        [HttpPost]
        public IActionResult Index(ChessViewModel input)
        {
            var result = new ChessViewModel { Request = input.Request, Response = null };
            if (input.Request?.Position is null || input.Request?.Piece is null)
            {
                return View(result);
            }

            result.Response = GetValidMoves(input.Request.Piece.Value, input.Request.Position.Value, input.Request.BlackPosition);

            return View(result);
        }

        private List<string> GetValidMoves(Piece piece, Move position, Move? blackPosition)

        {
            switch (piece)
            {
                case Piece.Knight:
                    return MoveKnight(position, blackPosition.ToString());
                case Piece.Bishop:
                    return MoveBishop(position, blackPosition.ToString());
                case Piece.Queen:
                    return MoveQueen(position, blackPosition.ToString());
                case Piece.Pawn:
                    return MovePawn(position, blackPosition.ToString());
                case Piece.King:
                    return MoveKing(position, blackPosition.ToString());
                case Piece.Rook:
                    return MoveRook(position, blackPosition.ToString());
                default:
                    return new List<string>();
            }
        }

        private List<string> MoveRook(Move position, string? blackPos)
        {
            var validMoves = new List<string>();
            string posString = position.ToString();
            char columnChar = posString[0];
            int row = int.Parse(posString[1].ToString());

            int x = columnChar - 'A';
            int y = 8 - row;
            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            for (int dir = 0; dir < 4; dir++)
            {
                int newX = x + dx[dir];
                int newY = y + dy[dir];

                while (newX >= 0 && newX < 8 && newY >= 0 && newY < 8)
                {
                    string target = $"{(char)('A' + newX)}{8 - newY}";

                    validMoves.Add(target);
                    if (target == blackPos) break;

                    newX += dx[dir];
                    newY += dy[dir];
                }
            }

            return validMoves;
        }


        private List<string> MoveKing(Move position, string? blackPos)
        {
            var validMoves = new List<string>();
            string posString = position.ToString();
            char columnChar = posString[0];
            int row = int.Parse(posString[1].ToString());

            int x = columnChar - 'A';
            int y = 8 - row;

            int[] dx = { 1, 1, 0, -1, -1, -1, 0, 1 };
            int[] dy = { 0, 1, 1, 1, 0, -1, -1, -1 };

            for (int i = 0; i < dx.Length; i++)
            {
                int newX = x + dx[i];
                int newY = y + dy[i];

                if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8)
                {
                    string target = $"{(char)('A' + newX)}{8 - newY}";

                   
                    validMoves.Add(target);
                }
            }

            return validMoves;
        }


        private List<string> MovePawn(Move position, string? blackPos)
        {
            var validMoves = new List<string>();
            string posString = position.ToString();
            char columnChar = posString[0];
            int row = int.Parse(posString[1].ToString());

            int x = columnChar - 'A';   
            int y = 8 - row;            

           
            if (y - 1 >= 0)
            {
                string forwardPos = $"{(char)('A' + x)}{8 - (y - 1)}";
                if (forwardPos != blackPos)
                {
                    validMoves.Add(forwardPos);
                }

                
                if (row == 2 && y - 2 >= 0)
                {
                    string twoForward = $"{(char)('A' + x)}{8 - (y - 2)}";
                    string oneForward = $"{(char)('A' + x)}{8 - (y - 1)}";
                    if (oneForward != blackPos && twoForward != blackPos)
                    {
                        validMoves.Add(twoForward);
                    }
                }
            }

          
            if (x - 1 >= 0 && y - 1 >= 0)
            {
                string diagLeft = $"{(char)('A' + (x - 1))}{8 - (y - 1)}";
                if (diagLeft == blackPos)
                {
                    validMoves.Add(diagLeft);
                }
            }

            if (x + 1 < 8 && y - 1 >= 0)
            {
                string diagRight = $"{(char)('A' + (x + 1))}{8 - (y - 1)}";
                if (diagRight == blackPos)
                {
                    validMoves.Add(diagRight);
                }
            }

            return validMoves;
        }



        private List<string> MoveQueen(Move position, string? blackPos)
        {
            var validMoves = new List<string>();
            string posString = position.ToString();
            char columnChar = posString[0];
            int row = int.Parse(posString[1].ToString());
            int x = columnChar - 'A';
            int y = 8 - row;

            int[] dx = { 1, 1, 0, -1, -1, -1, 0, 1 };
            int[] dy = { 0, 1, 1, 1, 0, -1, -1, -1 };

            for (int dir = 0; dir < 8; dir++)
            {
                int newX = x + dx[dir];
                int newY = y + dy[dir];

                while (newX >= 0 && newX < 8 && newY >= 0 && newY < 8)
                {
                    string target = $"{(char)('A' + newX)}{8 - newY}";

                    validMoves.Add(target);
                    if (target == blackPos) break;

                    newX += dx[dir];
                    newY += dy[dir];
                }
            }

            return validMoves;
        }



        private List<string> MoveBishop(Move position, string? blackPos)
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
                    string target = $"{(char)('A' + newX)}{8 - newY}";

                    validMoves.Add(target);
                    if (target == blackPos) break;

                    newX += dx[dir];
                    newY += dy[dir];
                }
            }

            return validMoves;
        }



        private List<string> MoveKnight(Move position, string? blackPos)
        {
            var validMoves = new List<string>();

            string posString = position.ToString();
            char columnChar = posString[0];
            int row = int.Parse(posString[1].ToString());

            int x = columnChar - 'A';
            int y = 8 - row;

            int[,] moves = {
        { -2, -1 }, { -2, 1 }, { -1, -2 }, { -1, 2 },
        { 1, -2 }, { 1, 2 }, { 2, -1 }, { 2, 1 }
    };

            for (int i = 0; i < moves.GetLength(0); i++)
            {
                int newX = x + moves[i, 0];
                int newY = y + moves[i, 1];

                if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8)
                {
                    string target = $"{(char)('A' + newX)}{8 - newY}";
                    validMoves.Add(target);
                }
            }

            return validMoves;
        }

    }
}
