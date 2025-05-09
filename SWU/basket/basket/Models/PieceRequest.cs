using basket.Enums;

namespace basket.Models
{
    public class PieceRequest
    {
        public Piece? Piece { get; set; }
        public Move? Position { get; set; }

        public Piece? BlackPiece { get; set; }

        public Move? BlackPosition { get; set; }



    }
}
