﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPFChess
{
    class Bishop:Figure
    {
        public Bishop(int color, string row, string column, int game_direction): base(color, Globals.figure_bishop, row, column, game_direction)
        {
            
        }

     
        protected override void setFigureImage()
        {
            string image_source = "";

            if(color==Globals.color_black)
                image_source = Globals.figures_images_path + "black_bishop.png";
            else
                image_source = Globals.figures_images_path + "white_bishop.png";
            
            figure_image = new BitmapImage(new Uri(image_source)); 
        }

        public override List<string> getPossibleMoves(Board board)
        {
            List<string> possible_moves = new List<string>();
            string current_row = row;
            string current_column = column;

            while (true)
            {
                current_row = getNextRow(current_row);
                current_column = getNextColumn(current_column);

                if (!current_row.Equals("") && !current_column.Equals(""))
                {
                    if (board.getFigure(current_row, current_column) == null)
                        possible_moves.Add(current_column + current_row);
                    else if (board.getFigure(current_row, current_column).getColor() != color)
                    {
                        possible_moves.Add(current_column + current_row);
                        break;
                    }
                    else
                        break;
                }
                else
                    break;
            }

            current_row = row;
            current_column = column;
            while (true)
            {
                current_row = getPreviousRow(current_row);
                current_column = getPreviousColumn(current_column);

                if (!current_row.Equals("") && !current_column.Equals(""))
                {
                    if (board.getFigure(current_row, current_column) == null)
                        possible_moves.Add(current_column + current_row);
                    else if (board.getFigure(current_row, current_column).getColor() != color)
                    {
                        possible_moves.Add(current_column + current_row);
                        break;
                    }
                    else
                        break;
                }
                else
                    break;
            }

            current_row = row;
            current_column = column;
            while (true)
            {
                current_row = getNextRow(current_row);
                current_column = getPreviousColumn(current_column);

                if (!current_row.Equals("") && !current_column.Equals(""))
                {
                    if (board.getFigure(current_row, current_column) == null)
                        possible_moves.Add(current_column + current_row);
                    else if (board.getFigure(current_row, current_column).getColor() != color)
                    {
                        possible_moves.Add(current_column + current_row);
                        break;
                    }
                    else
                        break;
                }
                else
                    break;
            }

            current_row = row;
            current_column = column;
            while (true)
            {
                current_row = getPreviousRow(current_row);
                current_column = getNextColumn(current_column);

                if (!current_row.Equals("") && !current_column.Equals(""))
                {
                    if (board.getFigure(current_row, current_column) == null)
                        possible_moves.Add(current_column + current_row);
                    else if (board.getFigure(current_row, current_column).getColor() != color)
                    {
                        possible_moves.Add(current_column + current_row);
                        break;
                    }
                    else
                        break;
                }
                else
                    break;
            }
            
            return possible_moves;
        }
    }
}
