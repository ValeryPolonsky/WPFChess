using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPFChess
{
    abstract class Figure
    {
        protected int color;
        protected int type;
        protected string row;
        protected string column;
        protected BitmapImage figure_image;
        protected int game_direction;
        protected bool first_move;

        public Figure(int color, int type, string row, string column,int game_direction)
        {
            this.color = color;
            this.type = type;
            this.row = row;
            this.column = column;
            this.game_direction = game_direction;
            first_move = true;
            setFigureImage();
        }
       
        protected abstract void setFigureImage();
        public abstract List<string> getPossibleMoves(Board board);

        public int getColor()
        {
            return color;
        }

        public int getType()
        {
            return type;
        }

        public int getGameDirection()
        {
            return game_direction;
        }

        public void setLocation(string row, string column)
        {
            this.row = row;
            this.column = column;
            first_move = false;
        }

        public BitmapImage getFigureImage()
        {
            return figure_image;
        }

        protected string getNextRow(string current_row)
        {
            int row_index=-1000;
            Int32.TryParse(current_row, out row_index);

            row_index++;

            if (row_index > Globals.board_size||row_index<0)
                return "";
            else
                return row_index.ToString();
        }

        protected string getPreviousRow(string current_row)
        {
            int row_index=-1000;
            Int32.TryParse(current_row, out row_index);

            row_index--;

            if (row_index < 0)
                return "";
            else
                return row_index.ToString();
        }

        protected string getNextColumn(string current_column)
        {
            if (!current_column.Equals(""))
            {
                string next_column = ((char)((char)((int)current_column[0]) + 1)).ToString();

                if (next_column[0] > ((int)'H'))               
                    return "";               
                else
                    return next_column;
            }
            else
                return "";
        }

        protected string getPreviousColumn(string current_column)
        {
            if (!current_column.Equals(""))
            {
                string previous_column = ((char)((char)((int)current_column[0]) - 1)).ToString();

                if (previous_column[0] < ((int)'A'))               
                    return "";                
                else
                    return previous_column;
            }
            else
                return "";
        }




        
    }
}
