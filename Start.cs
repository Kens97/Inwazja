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
        // private Figure figura = new Figure();

        private const int tileWidth = 20;
        private const int tileHeight = 20;

        private const int MarginWidth = 40;
        private const int MarginHeigt = 40;

        private const int FigureHolderWidth = 22 * tileWidth;
        private const int FigureHolderHeight = 13 * tileHeight;

        public const int size = 20;
        private static readonly Size tileSize = new Size(tileWidth, tileHeight);
        private static readonly Size FigureHolderSize = new Size(FigureHolderWidth, FigureHolderHeight);


        private Point tileLocation = new Point(tileSize.Width / 2, tileSize.Height / 2);
        private Point FigureHolderLocation = new Point(MarginWidth * 2 + tileWidth * size + FigureHolderWidth / 2, MarginHeigt + FigureHolderHeight / 2);
        public PictureBox[,] Board;
        public PictureBox[,] FigureHolder;
        public PictureBox picture;

        //static List<Figure> Figures = new List<Figure>();

        public Start()
        {
            InitializeComponent();
            DrawBoard();
            DrawFigureHolder();
            Draw_Picturbox();
            DrawCentralTile();
        }

        private void DrawBoard()
        {
            Board = new PictureBox[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Board[i, j] = new PictureBox
                    {
                        Size = tileSize,
                        Location = new Point(MarginWidth + i * tileWidth, MarginHeigt + j * tileHeight),
                        BorderStyle = BorderStyle.None,
                        BackColor = Color.Black,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    Controls.Add(Board[i, j]);

                }
            }
        }

        private void Draw_Picturbox()
        {
            picture = new PictureBox
            {
                Size = tileSize,
                Location = new Point(600,600),
                BorderStyle = BorderStyle.None,
                BackColor = Color.Blue,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(picture);
        }


        private void DrawFigureHolder()
        {
            FigureHolder = new PictureBox[22, 13];

            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    FigureHolder[i, j] = new PictureBox
                    {
                        Size = tileSize,
                        Location = new Point(MarginWidth * 2 + 20 * tileWidth + i * tileWidth, MarginHeigt * 2 + tileHeight + j * tileHeight),
                        BorderStyle = BorderStyle.Fixed3D,
                        BackColor = Color.Green
                    };
                    Controls.Add(FigureHolder[i, j]);

                }
            }
        }

        private void DrawCentralTile()
        {
            picture.Image = Image.FromFile(ImagePath.YellowImagePath);
        }

        public bool moveDetect = false;

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            moveDetect = true;
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveDetect)
            {
                Point pozycja = new Point();
                this.Cursor = new Cursor(Cursor.Current.Handle);
                pozycja = this.PointToClient(Cursor.Position);
                picture.Location = pozycja;
            }
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            if (moveDetect)
            {
                moveDetect = false;
            }
        }
    }
}
