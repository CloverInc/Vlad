using System;
namespace test
{
	public class SurfMap
	{
		protected int n { get; set; }
		protected int m { get; set; }
		protected int k { get; set; }
		protected struct Cell 
		{
			BigObj background = new BigObj();
			BigObj structures = new BigObj();
			BigObj character  = new BigObj();
		}
		protected Cell[, ,] Map = new Cell [n, m, k];
		public SurfMap()
		{
			n = m = k = 0;
		}
		public SurfMap(int a, int b, int c)
		{
			n = a;
			m = b;
			k = c;
		}
		public void setObjectOnMap (int a, int b, int c, BigObj someObj, int objType)
		{
			switch (objType) {
			case 1:
				Map [a, b, c].background = someObj;
				break;
			case 2:
				Map [a, b, c].structures = someObj;
				break;
			case 3:
				Map [a, b, c].character = someObj;
				break;
			default:
				//some mistake
				break;
			}
		}
		public void moveCharacter (int x1, int y1, int z1, int x2, int y2, int z2) //like a test example
		{
			Map [x2, y2, z2].character = Map [x1, y1, z1].character;
			Map [x1, y1, z1].character = new BigObj ();
		}
	}
}