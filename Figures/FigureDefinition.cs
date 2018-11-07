using System;

public class FigureDefinition   
{
    public class FigureDefinition
    {
        public Figure.FigureColor PieceColor { get; set; }
        public Figure.FigureType PieceType { get; set; }
        public Image PieceImage { get; set; }
        public Tuple<int, int> StartingPosition { get; set; }
        public Tuple<int, int> CurrentPosition { get; set; }
        public Tuple<int, int>[] ValidTurns { get; set; }
        public bool WasMoved { get; set; }
    }










}
