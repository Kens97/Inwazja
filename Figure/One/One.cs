using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inwazja.Figure.One
{
    public sealed class One : Figure
    {
        public One(FigureDefinition definition) : base(definition)
        {
            Moves = Moves.Distinct().ToList();
        }

        protected override List<Tuple<int, int>> GetValidTurns()
        {
            return null;
        }
    }
}
