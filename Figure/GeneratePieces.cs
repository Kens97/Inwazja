using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inwazja.Figure.Figure;

namespace Inwazja.Figure
{
    class GeneratePieces
    {
        private readonly FigureType pieceType;
        private readonly int startingRowWhite = 0;
        private readonly int startingRowBlack = 7;
        private readonly int startingColumn;
        private readonly int endingColumn;
        private readonly int increase;
        private readonly string whitePieceImagePath;
        private readonly string blackPieceImagePath;

        public GeneratePieces(FigureType pieceType, int startingColumn, int endingColumn, int increase, string whitePieceImagePath, string blackPieceImagePath)
        {
            this.pieceType = pieceType;
            this.startingColumn = startingColumn;
            this.endingColumn = endingColumn;
            this.increase = increase;
            this.whitePieceImagePath = whitePieceImagePath;
            this.blackPieceImagePath = blackPieceImagePath;
        }

        public IEnumerable<FigureDefinition> GenerateBlackPieces()
        {
            List<FigureDefinition> pieces = new List<FigureDefinition>();

            for (int i = startingColumn; i <= endingColumn; i += increase)
            {
                CooperativeForm.Board[startingRowBlack][i] = true;
                FigureDefinition piece = new FigureDefinition
                {
                    PieceColor = FigureColor.Black,
                    PieceType = pieceType,
                    PieceImage = Image.FromFile(blackPieceImagePath),
                    StartingPosition = new Tuple<int, int>(startingRowBlack, i),
                    CurrentPosition = new Tuple<int, int>(startingRowBlack, i),
                    WasMoved = false
                };
                pieces.Add(piece);

            }
            return pieces;
        }

    }
}

