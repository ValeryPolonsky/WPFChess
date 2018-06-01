using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFChess
{
    public static class Globals
    {
        public const int color_white = 0;
        public const int color_black = 1;
        public const int figure_pawn = 2;
        public const int figure_king = 3;
        public const int figure_queen = 4;
        public const int figure_rook = 5;
        public const int figure_bishop = 6;
        public const int figure_knight = 7;
        public const int board_size = 8;
        public const int game_direction_up = 9;
        public const int game_direction_down = 10;

        public const string figures_images_path = @"D:\Programming\My Tarining\C#\WPF\WPFChess\Figures\";
    }
}
