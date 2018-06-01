using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFChess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Chess chess;
        private string old_row, old_column, new_row, new_column;
        private int click_counter;
        private int temp_counter = 0;

        public MainWindow()
        {
            InitializeComponent();
            chess = new Chess();
            setFigures();
            setListeners();
            old_row = ""; old_column = ""; new_row = ""; new_column = "";
            click_counter = 0;
            this.SizeChanged += WindowOnSizeChanged;
        }

        private void WindowOnSizeChanged(object sender, SizeChangedEventArgs args)
        {
            //Console.WriteLine("Width: "+args.NewSize.Width+"Height: "+args.NewSize.Height);


            Application.Current.MainWindow.Height = args.NewSize.Width;
            Application.Current.MainWindow.Width = args.NewSize.Width;
        }

        private void setListeners()
        {
            Border_A8.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_A7.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_A6.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_A5.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_A4.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_A3.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_A2.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_A1.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);

            Border_B8.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_B7.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_B6.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_B5.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_B4.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_B3.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_B2.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_B1.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);

            Border_C8.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_C7.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_C6.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_C5.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_C4.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_C3.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_C2.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_C1.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);

            Border_D8.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_D7.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_D6.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_D5.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_D4.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_D3.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_D2.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_D1.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);

            Border_E8.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_E7.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_E6.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_E5.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_E4.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_E3.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_E2.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_E1.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);

            Border_F8.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_F7.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_F6.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_F5.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_F4.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_F3.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_F2.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_F1.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);

            Border_G8.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_G7.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_G6.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_G5.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_G4.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_G3.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_G2.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_G1.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);

            Border_H8.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_H7.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_H6.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_H5.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_H4.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_H3.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_H2.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);
            Border_H1.AddHandler(Border.MouseLeftButtonDownEvent, new RoutedEventHandler(boardClicked), true);


        }

        private void setFigures()
        {
            //string source=@"S:\Administrators\Valery\Study\WPF\WPFChess\WPFChess\Figures\black_pawn.png";
            //A8.Source = new BitmapImage(new Uri(source));            

            A8.Source = chess.getFigureImage("8", "A"); B8.Source = chess.getFigureImage("8", "B"); C8.Source = chess.getFigureImage("8", "C"); D8.Source = chess.getFigureImage("8", "D"); E8.Source = chess.getFigureImage("8", "E"); F8.Source = chess.getFigureImage("8", "F"); G8.Source = chess.getFigureImage("8", "G"); H8.Source = chess.getFigureImage("8", "H");
            A7.Source = chess.getFigureImage("7", "A"); B7.Source = chess.getFigureImage("7", "B"); C7.Source = chess.getFigureImage("7", "C"); D7.Source = chess.getFigureImage("7", "D"); E7.Source = chess.getFigureImage("7", "E"); F7.Source = chess.getFigureImage("7", "F"); G7.Source = chess.getFigureImage("7", "G"); H7.Source = chess.getFigureImage("7", "H");
            A6.Source = chess.getFigureImage("6", "A"); B6.Source = chess.getFigureImage("6", "B"); C6.Source = chess.getFigureImage("6", "C"); D6.Source = chess.getFigureImage("6", "D"); E6.Source = chess.getFigureImage("6", "E"); F6.Source = chess.getFigureImage("6", "F"); G6.Source = chess.getFigureImage("6", "G"); H6.Source = chess.getFigureImage("6", "H");
            A5.Source = chess.getFigureImage("5", "A"); B5.Source = chess.getFigureImage("5", "B"); C5.Source = chess.getFigureImage("5", "C"); D5.Source = chess.getFigureImage("5", "D"); E5.Source = chess.getFigureImage("5", "E"); F5.Source = chess.getFigureImage("5", "F"); G5.Source = chess.getFigureImage("5", "G"); H5.Source = chess.getFigureImage("5", "H");
            A4.Source = chess.getFigureImage("4", "A"); B4.Source = chess.getFigureImage("4", "B"); C4.Source = chess.getFigureImage("4", "C"); D4.Source = chess.getFigureImage("4", "D"); E4.Source = chess.getFigureImage("4", "E"); F4.Source = chess.getFigureImage("4", "F"); G4.Source = chess.getFigureImage("4", "G"); H4.Source = chess.getFigureImage("4", "H");
            A3.Source = chess.getFigureImage("3", "A"); B3.Source = chess.getFigureImage("3", "B"); C3.Source = chess.getFigureImage("3", "C"); D3.Source = chess.getFigureImage("3", "D"); E3.Source = chess.getFigureImage("3", "E"); F3.Source = chess.getFigureImage("3", "F"); G3.Source = chess.getFigureImage("3", "G"); H3.Source = chess.getFigureImage("3", "H");
            A2.Source = chess.getFigureImage("2", "A"); B2.Source = chess.getFigureImage("2", "B"); C2.Source = chess.getFigureImage("2", "C"); D2.Source = chess.getFigureImage("2", "D"); E2.Source = chess.getFigureImage("2", "E"); F2.Source = chess.getFigureImage("2", "F"); G2.Source = chess.getFigureImage("2", "G"); H2.Source = chess.getFigureImage("2", "H");
            A1.Source = chess.getFigureImage("1", "A"); B1.Source = chess.getFigureImage("1", "B"); C1.Source = chess.getFigureImage("1", "C"); D1.Source = chess.getFigureImage("1", "D"); E1.Source = chess.getFigureImage("1", "E"); F1.Source = chess.getFigureImage("1", "F"); G1.Source = chess.getFigureImage("1", "G"); H1.Source = chess.getFigureImage("1", "H");
        }

        private void boardClicked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(((Border)sender).Name);
            click_counter++;
            temp_counter++;

            if (temp_counter == 6)
            {
                int i = 0;
            }


            if (click_counter == 1)
            {
                string[] grid_name = ((Border)sender).Name.Split('_');
                old_row = grid_name[1][1].ToString();
                old_column = grid_name[1][0].ToString();

                if (chess.getFigureImage(old_row, old_column) == null)
                    click_counter = 0;
            }

            if (click_counter == 2)
            {
                string[] grid_name = ((Border)sender).Name.Split('_');
                new_row = grid_name[1][1].ToString();
                new_column = grid_name[1][0].ToString();
                chess.moveFigure(old_row, old_column, new_row, new_column);
                click_counter = 0;
                old_row = old_column = new_row = new_column = "";
                setFigures();
            }

        }
    }
}
