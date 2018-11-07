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
    public partial class Start : Form
    {

        private const int tileWidth = 20;
        private const int tileHeight = 20;

        private const int MarginWidth = 40;
        private const int MarginHeigt = 40;

        private const int FigureHolderWidth = 200 ;
        private const int FigureHolderHeight =200;

        public const int size= 20;
        private static readonly Size tileSize = new Size(tileWidth, tileHeight);
        private static readonly Size FigureHolderSize = new Size(FigureHolderWidth, FigureHolderHeight);


        private Point tileLocation = new Point(tileSize.Width/2, tileSize.Height/2);
        private Point FigureHolderLocation = new Point(MarginWidth*2 + tileWidth*size+ FigureHolderWidth/2, MarginHeigt + FigureHolderHeight/2);
        public Start()
        {
            InitializeComponent();
            DrawBoard();
            DrawFigureHolder();
        }

        private void DrawBoard()
        {


            PictureBox[][] Board = new PictureBox[size][];
            for (int i = 0; i < size; i++)
            {
                Board[i] = new PictureBox[size];
            }


            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    Board[i][j] = new PictureBox
                    {
                        Size = tileSize,
                        Location = new Point(MarginWidth + i*tileWidth, MarginHeigt + j*tileHeight),
                        BorderStyle = BorderStyle.Fixed3D,
                        BackColor=Color.Black,
                    };
                    Controls.Add(Board[i][j]);
                    
                }
            }
        }

        private void DrawFigureHolder ()
        {
            PictureBox FigureHolder = new PictureBox
            {
                Size = FigureHolderSize,
                Location = FigureHolderLocation,
                BorderStyle = BorderStyle.Fixed3D,
            };
            Controls.Add(FigureHolder);
        }
    }
}
