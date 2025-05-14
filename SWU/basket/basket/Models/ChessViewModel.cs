namespace basket.Models
{
    public class ChessViewModel
    {
        public PieceRequest Request { get; set; }
        public List<string> Response { get; set; }

        public List<FigurePosition> Figures { get; set; } = new();
    }
}
