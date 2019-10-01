using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HapGyul {
	class Box {
		//shape: 0 = triangle, 1 = circle, 2 = square
		//scolor: 0 = red, 1 = blue, 2 = yellow
		//bcolor: 0 = beige, 1 = black, 2 = white
		private int shape;
		private int scolor;
		private int bcolor;

		public Box() {
			Random rnd = new Random();

			shape = rnd.Next(3);
			scolor = rnd.Next(3);
			bcolor = rnd.Next(3);
		}
		public Box(Random rnd) {

			shape = rnd.Next(3);
			scolor = rnd.Next(3);
			bcolor = rnd.Next(3);
		}

		public int getShape() {
			return shape;
		}

		public int getSColor() {
			return scolor;
		}

		public int getBColor() {
			return bcolor;
		}
	}
}
