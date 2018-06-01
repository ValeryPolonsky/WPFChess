using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPFChess
{
    class Knight:Figure
    {
        public Knight(int color, string row, string column, int game_direction):base(color, Globals.figure_knight, row, column, game_direction)
        {
            
        }

     
        protected override void setFigureImage()
        {
            string image_source = "";

            if(color==Globals.color_black)
                image_source = Globals.figures_images_path + "black_knight.png";
            else
                image_source = Globals.figures_images_path + "white_knight.png";
            
            figure_image = new BitmapImage(new Uri(image_source)); 
        }

        public override List<string> getPossibleMoves(Board board)
        {
            List<string> possible_moves = new List<string>();
            string current_row = row;
            string currenct_column = column;
           
            current_row = getNextRow(current_row);
            current_row = getNextRow(current_row);
            currenct_column = getNextColumn(currenct_column);

            if (!current_row.Equals("") && !currenct_column.Equals(""))
            {
                if (board.getFigure(current_row, currenct_column) == null)
                    possible_moves.Add(currenct_column + current_row);
                else if (board.getFigure(current_row, currenct_column).getColor() != color)
                    possible_moves.Add(currenct_column + current_row);
            }


            current_row = row;
            currenct_column = column;
            current_row = getNextRow(current_row);
            current_row = getNextRow(current_row);
            currenct_column = getPreviousColumn(currenct_column);

            if (!current_row.Equals("") && !currenct_column.Equals(""))
            {
                if (board.getFigure(current_row, currenct_column) == null)
                    possible_moves.Add(currenct_column + current_row);
                else if (board.getFigure(current_row, currenct_column).getColor() != color)
                    possible_moves.Add(currenct_column + current_row);
            }


            current_row = row;
            currenct_column = column;
            current_row = getPreviousRow(current_row);
            current_row = getPreviousRow(current_row);
            currenct_column = getNextColumn(currenct_column);

            if (!current_row.Equals("") && !currenct_column.Equals(""))
            {
                if (board.getFigure(current_row, currenct_column) == null)
                    possible_moves.Add(currenct_column + current_row);
                else if (board.getFigure(current_row, currenct_column).getColor() != color)
                    possible_moves.Add(currenct_column + current_row);
            }


            current_row = row;
            currenct_column = column;
            current_row = getPreviousRow(current_row);
            current_row = getPreviousRow(current_row);
            currenct_column = getPreviousColumn(currenct_column);

            if (!current_row.Equals("") && !currenct_column.Equals(""))
            {
                if (board.getFigure(current_row, currenct_column) == null)
                    possible_moves.Add(currenct_column + current_row);
                else if (board.getFigure(current_row, currenct_column).getColor() != color)
                    possible_moves.Add(currenct_column + current_row);
            }


            current_row = row;
            currenct_column = column;
            current_row = getNextRow(current_row);          
            currenct_column = getNextColumn(currenct_column);
            currenct_column = getNextColumn(currenct_column);

            if (!current_row.Equals("") && !currenct_column.Equals(""))
            {
                if (board.getFigure(current_row, currenct_column) == null)
                    possible_moves.Add(currenct_column + current_row);
                else if (board.getFigure(current_row, currenct_column).getColor() != color)
                    possible_moves.Add(currenct_column + current_row);
            }


            current_row = row;
            currenct_column = column;
            current_row = getNextRow(current_row);
            currenct_column = getPreviousColumn(currenct_column);
            currenct_column = getPreviousColumn(currenct_column);

            if (!current_row.Equals("") && !currenct_column.Equals(""))
            {
                if (board.getFigure(current_row, currenct_column) == null)
                    possible_moves.Add(currenct_column + current_row);
                else if (board.getFigure(current_row, currenct_column).getColor() != color)
                    possible_moves.Add(currenct_column + current_row);
            }


            current_row = row;
            currenct_column = column;
            current_row = getPreviousRow(current_row);
            currenct_column = getNextColumn(currenct_column);
            currenct_column = getNextColumn(currenct_column);

            if (!current_row.Equals("") && !currenct_column.Equals(""))
            {
                if (board.getFigure(current_row, currenct_column) == null)
                    possible_moves.Add(currenct_column + current_row);
                else if (board.getFigure(current_row, currenct_column).getColor() != color)
                    possible_moves.Add(currenct_column + current_row);
            }


            current_row = row;
            currenct_column = column;
            current_row = getPreviousRow(current_row);
            currenct_column = getPreviousColumn(currenct_column);
            currenct_column = getPreviousColumn(currenct_column);

            if (!current_row.Equals("") && !currenct_column.Equals(""))
            {
                if (board.getFigure(current_row, currenct_column) == null)
                    possible_moves.Add(currenct_column + current_row);
                else if (board.getFigure(current_row, currenct_column).getColor() != color)
                    possible_moves.Add(currenct_column + current_row);
            }


            return possible_moves;
        }
    }
}
