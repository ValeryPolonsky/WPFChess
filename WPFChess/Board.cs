using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPFChess
{
    class Board
    {
        private Dictionary<string,Figure> board;

        public Board()
        {
            board = new Dictionary<string, Figure>();           
        }

       
        public void initializeBoard()
        {
            board["A8"] = new Rook(Globals.color_black,"8","A",Globals.game_direction_down);
            board["B8"] = new Knight(Globals.color_black, "8", "B", Globals.game_direction_down);
            board["C8"] = new Bishop(Globals.color_black, "8", "C", Globals.game_direction_down);
            board["D8"] = new Queen(Globals.color_black, "8", "D", Globals.game_direction_down);
            board["E8"] = new King(Globals.color_black, "8", "E", Globals.game_direction_down);
            board["F8"] = new Bishop(Globals.color_black, "8", "F", Globals.game_direction_down);
            board["G8"] = new Knight(Globals.color_black, "8", "G", Globals.game_direction_down);
            board["H8"] = new Rook(Globals.color_black, "8", "H", Globals.game_direction_down);

            board["A7"] = new Pawn(Globals.color_black, "7", "A", Globals.game_direction_down);
            board["B7"] = new Pawn(Globals.color_black, "7", "B", Globals.game_direction_down);
            board["C7"] = new Pawn(Globals.color_black, "7", "C", Globals.game_direction_down);
            board["D7"] = new Pawn(Globals.color_black, "7", "D", Globals.game_direction_down);
            board["E7"] = new Pawn(Globals.color_black, "7", "E", Globals.game_direction_down);
            board["F7"] = new Pawn(Globals.color_black, "7", "F", Globals.game_direction_down);
            board["G7"] = new Pawn(Globals.color_black, "7", "G", Globals.game_direction_down);
            board["H7"] = new Pawn(Globals.color_black, "7", "H", Globals.game_direction_down);


            board["A1"] = new Rook(Globals.color_white, "1", "A", Globals.game_direction_up);
            board["B1"] = new Knight(Globals.color_white, "1", "B", Globals.game_direction_up);
            board["C1"] = new Bishop(Globals.color_white, "1", "C", Globals.game_direction_up);
            board["D1"] = new Queen(Globals.color_white, "1", "D", Globals.game_direction_up);
            board["E1"] = new King(Globals.color_white, "1", "E", Globals.game_direction_up);
            board["F1"] = new Bishop(Globals.color_white, "1", "F", Globals.game_direction_up);
            board["G1"] = new Knight(Globals.color_white, "1", "G", Globals.game_direction_up);
            board["H1"] = new Rook(Globals.color_white, "1", "H", Globals.game_direction_up);

            board["A2"] = new Pawn(Globals.color_white, "2", "A", Globals.game_direction_up);
            board["B2"] = new Pawn(Globals.color_white, "2", "B", Globals.game_direction_up);
            board["C2"] = new Pawn(Globals.color_white, "2", "C", Globals.game_direction_up);
            board["D2"] = new Pawn(Globals.color_white, "2", "D", Globals.game_direction_up);
            board["E2"] = new Pawn(Globals.color_white, "2", "E", Globals.game_direction_up);
            board["F2"] = new Pawn(Globals.color_white, "2", "F", Globals.game_direction_up);
            board["G2"] = new Pawn(Globals.color_white, "2", "G", Globals.game_direction_up);
            board["H2"] = new Pawn(Globals.color_white, "2", "H", Globals.game_direction_up);
        }

        public BitmapImage getFigureImage(string row, string column)
        {
            if (board.ContainsKey(column + row))
                return board[column + row].getFigureImage();
            else
                return null;
        }

        public Figure getFigure(string row, string column)
        {
            if (board.ContainsKey(column + row))
                return board[column + row];
            else
                return null;
        }

        public void moveFigure(string old_row, string old_column, string new_row, string new_column)
        {
            if (board.ContainsKey(old_column + old_row))
            {
                List<string>possible_moves=board[old_column + old_row].getPossibleMoves(this);

                if (possible_moves != null)
                {
                    if (possible_moves.Contains(new_column + new_row))
                    {
                        board[new_column + new_row] = board[old_column + old_row];
                        board[new_column + new_row].setLocation(new_row, new_column);
                        board.Remove(old_column + old_row);
                    }
                }
            }
        }
    }
}
