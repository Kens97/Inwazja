using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Inwazja
{
    public abstract class Figure
        public enum FigureType
        {
            one,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine,
            ten,
            eleven,
            twelve,
            thirteen,
            fourteen,
            fifteen,
            sixteen,
            seventeen,
            eighteen,
            nineteen,
            twenty
        }
        
        public enum FigureColor
        {
            green,
            red,
            blue,
            yellow
        }

        private readonly FigureDefinition definition;

        public List<Tuple<int, int>> Moves { get; set; }

        public bool WasMoved
        {
            get { return definition.WasMoved; }
            set { definition.WasMoved = value; }
        }

        public FigureColor PieceColor
        {
            get { return definition.PieceColor; }
            set { definition.PieceColor = value; }
        }

        public FigureType PieceType
        {
            get { return definition.PieceType; }
            set { definition.PieceType = value; }
        }

        public Tuple<int, int> StartingPosition
        {
            get { return definition.StartingPosition; }
            set { definition.StartingPosition = value; }
        }

        public Tuple<int, int> CurrentPosition
        {
            get { return definition.CurrentPosition; }
            set { definition.CurrentPosition = value; }
        }

        protected Figure(FigureDefinition definition)
        {
            this.definition = definition;
        }

        public bool IsValidMove(Tuple<int, int> newPosition) => Moves.Contains(newPosition);









    }
}