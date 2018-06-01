using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPFChess
{
    class Chess
    {
        private Board board;

        public Chess()
        {
            board = new Board();
            board.initializeBoard();
        }

        public BitmapImage getFigureImage(string row,string column)
        {
            return board.getFigureImage(row,column);
        }

        public void moveFigure(string old_row, string old_column, string new_row, string new_column)
        {
            board.moveFigure(old_row,old_column,new_row,new_column);
        }
    }
}
