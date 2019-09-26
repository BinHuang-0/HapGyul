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

namespace HapGyul {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
//		private int times = 0;
//		private Box[,] board;
//		private Box[] hap;
		private Button[,] buttons = new Button[3, 3];

		public MainWindow() {
			InitializeComponent();

			Init_Board();
	}
		private void Button_Click(object sender, RoutedEventArgs e) {
		}

		private void Init_Board() {
			Random rnd = new Random();
			for(int i = 0; i < 3; i++) {
				for(int k = 0; k < 3; k++) {
					buttons[i, k] = CreateButton(rnd.Next(3), rnd.Next(3), rnd.Next(3));
					PlayingBoard.Children.Add(buttons[i, k]);
					Grid.SetColumn(buttons[i, k], k);
					Grid.SetRow(buttons[i, k], i + 1);
				}
			}
		}

		private Polygon GetTriangle(int scolor) {
			Polygon polygon = new Polygon();
			PointCollection points = new PointCollection();
			points.Add(new Point(10, 110));
			points.Add(new Point(60, 10));
			points.Add(new Point(110, 110));
			polygon.Points = points;

			switch (scolor) {
				case 0:
					polygon.Fill = Brushes.Red;
					break;
				case 1:
					polygon.Fill = Brushes.Blue;
					break;
				case 2:
					polygon.Fill = Brushes.Yellow;
					break;
				default:
					break;
			}
			polygon.Stroke = Brushes.Black;
			return polygon;
		}

		private Ellipse GetCircle(int scolor) {
			Ellipse ellipse = new Ellipse();

			ellipse.Width = 100;
			ellipse.Height = 100;

			switch (scolor) {
				case 0:
					ellipse.Fill = Brushes.Red;
					break;
				case 1:
					ellipse.Fill = Brushes.Blue;
					break;
				case 2:
					ellipse.Fill = Brushes.Yellow;
					break;
				default:
					break;
			}

			ellipse.Stroke = Brushes.Black;
			return ellipse;
		}

		private Polygon GetSquare(int scolor) {
			Polygon polygon = new Polygon();
			PointCollection points = new PointCollection();

			points.Add(new Point(10, 10));
			points.Add(new Point(110, 10));
			points.Add(new Point(110, 110));
			points.Add(new Point(10, 110));
			polygon.Points = points;

			switch (scolor) {
				case 0:
					polygon.Fill = Brushes.Red;
					break;
				case 1:
					polygon.Fill = Brushes.Blue;
					break;
				case 2:
					polygon.Fill = Brushes.Yellow;
					break;
				default:
					break;
			}
			
			polygon.Stroke = Brushes.Black;
			return polygon;
		}

		private Button CreateButton(int shape, int scolor, int bcolor) {
			Button button = new Button();

			button.Margin = new Thickness(5);

			switch (shape) {
				case 0:
					button.Content = GetTriangle(scolor);
					break;
				case 1:
					button.Content = GetCircle(scolor);
					break;
				case 2:
					button.Content = GetSquare(scolor);
					break;
				default:
					break;
			}

			switch (bcolor) {
				case 0:
					button.Background = Brushes.Beige;
					break;
				case 1:
					button.Background = Brushes.Black;
					break;
				case 2:
					button.Background = Brushes.White;
					break;
				default:
					break;
			}

			return button;
		}

	}

}
