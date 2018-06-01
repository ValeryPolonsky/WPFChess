using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPFChess
{
    class Pawn:Figure
    {
        
        public Pawn(int color, string row, string column, int game_direction):base(color, Globals.figure_pawn, row, column, game_direction)
        {
            
        }
         
        protected override void setFigureImage()
        {
            string image_source = "";

            if(color==Globals.color_black)
                image_source = Globals.figures_images_path + "black_pawn.png";
            else
                image_source = Globals.figures_images_path + "white_pawn.png";
            
            figure_image = new BitmapImage(new Uri(image_source)); 
        }

        public override List<string> getPossibleMoves(Board board)
        {
            List<string> possible_moves = new List<string>();

            string current_row=row;
            string current_column=column;

            if (first_move)
            {               
                if (game_direction == Globals.game_direction_up)
                {
                    current_row = getNextRow(current_row);

                    if (!current_row.Equals(""))
                    {
                        
                        if (board.getFigureImage(current_row, current_column) == null)
                            possible_moves.Add(current_column + current_row);

                        
                        if (board.getFigure(current_row, getNextColumn(current_column)) != null)
                        {                           
                            if (board.getFigure(current_row, getNextColumn(current_column)).getColor() != color)
                            {
                                possible_moves.Add(getNextColumn(current_column)+current_row);
                            }
                        }
                       
                        if (board.getFigure(current_row, getPreviousColumn(current_column)) != null)
                        {
                            if (board.getFigure(current_row, getPreviousColumn(current_column)).getColor() != color)
                            {
                                possible_moves.Add(getPreviousColumn(current_column)+current_row);
                            }
                        }
                    }

                    current_row = getNextRow(current_row);

                    if (!current_row.Equals(""))
                    {
                        if (board.getFigureImage(current_row, current_column) == null)
                            possible_moves.Add(current_column + current_row);
                    }
                }
                else
                {
                    current_row = getPreviousRow(current_row);

                    if (!current_row.Equals(""))
                    {
                        if (board.getFigureImage(current_row, current_column) == null)
                            possible_moves.Add(current_column + current_row);

                        if (board.getFigure(current_row, getNextColumn(current_column)) != null)
                        {
                            if (board.getFigure(current_row, getNextColumn(current_column)).getColor() != color)
                            {
                                possible_moves.Add(getNextColumn(current_column)+current_row);
                            }
                        }

                        if (board.getFigure(current_row, getPreviousColumn(current_column)) != null)
                        {
                            if (board.getFigure(current_row, getPreviousColumn(current_column)).getColor() != color)
                            {
                                possible_moves.Add(getPreviousColumn(current_column) + current_row);
                            }
                        }
                    }

                    current_row = getPreviousRow(current_row);

                    if (!current_row.Equals(""))
                    {
                        if (board.getFigureImage(current_row, current_column) == null)
                            possible_moves.Add(current_column + current_row);                        
                    }
                }
            }
            else
            {
                if (game_direction == Globals.game_direction_up)
                {
                    current_row = getNextRow(current_row);

                    if (!current_row.Equals(""))
                    {
                        if(board.getFigureImage(current_row,current_column)==null)
                            possible_moves.Add(current_column + current_row);

                        if (board.getFigure(current_row, getNextColumn(current_column)) != null)
                        {
                            if (board.getFigure(current_row, getNextColumn(current_column)).getColor() != color)
                            {
                                possible_moves.Add(getNextColumn(current_column) + current_row);
                            }
                        }

                        if (board.getFigure(current_row, getPreviousColumn(current_column)) != null)
                        {
                            if (board.getFigure(current_row, getPreviousColumn(current_column)).getColor() != color)
                            {
                                possible_moves.Add(getPreviousColumn(current_column) + current_row);
                            }
                        }
                    }
                }
                else
                {
                    current_row = getPreviousRow(current_row);

                    if (!current_row.Equals(""))
                    {
                        if (board.getFigureImage(current_row, current_column) == null)
                            possible_moves.Add(current_column + current_row);

                        if (board.getFigure(current_row, getNextColumn(current_column)) != null)
                        {
                            if (board.getFigure(current_row, getNextColumn(current_column)).getColor() != color)
                            {
                                possible_moves.Add(getNextColumn(current_column) + current_row);
                            }
                        }

                        if (board.getFigure(current_row, getPreviousColumn(current_column)) != null)
                        {
                            if (board.getFigure(current_row, getPreviousColumn(current_column)).getColor() != color)
                            {
                                possible_moves.Add(getPreviousColumn(current_column) + current_row);
                            }
                        }
                    }
                }
            }

            return possible_moves;
        }

      
    }
}
