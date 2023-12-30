/**********************************/
/*                                */
/* Author: BUI VAN NGHIA          */
/* Email: katatunix@yahoo.com     */
/*                 [May, 2008]    */
/*                                */
/**********************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;

namespace Lines2008
{
	class Algorithms
	{
		public static int[] splitNumber(int n, int length)
		{
			int[] digit = new int[length];
			while (n > 0)
			{
				if (length == 0) break;
				digit[--length] = n % 10;
				n = n / 10;
			}
			while (length > 0) digit[--length] = 0;
			return digit;
		}

		public static int[,] createNewMatrix()
		{
			Random random = new Random();
			int[,] a = new int[9, 9];

			int i, j, remain, count;

			for (i = 0; i < 9; i++)
				for (j = 0; j < 9; j++) a[i, j] = 0;

			count = 81;
			bool stop;
			do
			{
				remain = random.Next(count--) + 1;
				stop = false;
				for (i = 0; i < 9; i++)
				{
					if (stop) break;
					for (j = 0; j < 9; j++)
						if (a[i, j] == 0)
						{
							remain--;
							if (remain == 0)
							{
								a[i, j] = random.Next(7) + 1;
								stop = true;
								break;
							}
						}
				}
			} while (count > 76);

			addNextColor(a);

			return a;
		}

		public static void addNextColor(int[,] a)
		{
			Random random = new Random();
			int count = countEmpty(a);
			int tmp, i, j, remain;
			bool stop;

			for (tmp = 0; tmp < 3; tmp++)
			{
				remain = random.Next(count--) + 1;
				stop = false;
				for (i = 0; i < 9; i++)
				{
					if (stop) break;
					for (j = 0; j < 9; j++)
						if (a[i, j] == 0)
						{
							remain--;
							if (remain == 0)
							{
								a[i, j] = -(random.Next(7) + 1);
								stop = true;
								break;
							}
						}
				}
			}
		}

		public static int countEmpty(int[,] a)
		{
			int i, j, count = 0;
			for (i = 0; i < 9; i++)
				for (j = 0; j < 9; j++)
					if (a[i, j] <= 0) count++;
			return count;
		}

		public static ArrayList havePath(int[,] a, int i1, int j1, int i2, int j2)
		{
			int[,] dadi = new int[9, 9];
			int[,] dadj = new int[9, 9];
			
			int[] queuei = new int[81];
			int[] queuej = new int[81];
			
			int fist = 0, last = 0, x, y;

			for (x = 0; x < 9; x++)
				for (y = 0; y < 9; y++) dadi[x, y] = -1;

			queuei[0] = i2;
			queuej[0] = j2;
			dadi[i2, j2] = -2;

			while (fist <= last)
			{
				x = queuei[fist];
				y = queuej[fist];
				fist++;
				if (y > 0)
				{
					if (x == i1 & y - 1 == j1)
					{
						dadi[i1, j1] = x;
						dadj[i1, j1] = y;
						return buildPath(dadi, dadj, i1, j1);
					}
					if (dadi[x, y - 1] == -1)
						if (a[x, y - 1] <= 0)
						{
							last++;
							queuei[last] = x;
							queuej[last] = y - 1;
							dadi[x, y - 1] = x;
							dadj[x, y - 1] = y;
						}
				}
				if (y < 8)
				{
					if (x == i1 & y + 1 == j1)
					{
						dadi[i1, j1] = x;
						dadj[i1, j1] = y;
						return buildPath(dadi, dadj, i1, j1);
					}
					if (dadi[x, y + 1] == -1)
						if (a[x, y + 1] <= 0)
						{
							last++;
							queuei[last] = x;
							queuej[last] = y + 1;
							dadi[x, y + 1] = x;
							dadj[x, y + 1] = y;
						}
				}
				if (x > 0)
				{
					if (x - 1 == i1 & y == j1)
					{
						dadi[i1, j1] = x;
						dadj[i1, j1] = y;
						return buildPath(dadi, dadj, i1, j1);
					}
					if (dadi[x - 1, y] == -1)
						if (a[x - 1, y] <= 0)
						{
							last++;
							queuei[last] = x - 1;
							queuej[last] = y;
							dadi[x - 1, y] = x;
							dadj[x - 1, y] = y;
						}
				}
				if (x < 8)
				{
					if (x + 1 == i1 & y == j1)
					{
						dadi[i1, j1] = x;
						dadj[i1, j1] = y;
						return buildPath(dadi, dadj, i1, j1);
					}
					if (dadi[x + 1, y] == -1)
						if (a[x + 1, y] <= 0)
						{
							last++;
							queuei[last] = x + 1;
							queuej[last] = y;
							dadi[x + 1, y] = x;
							dadj[x + 1, y] = y;
						}
				}

			}
			return null;
		}

		public static ArrayList buildPath(int[,] dadi, int[,] dadj, int i1, int j1)
		{
			ArrayList arr = new ArrayList();
			int k;
			while (true)
			{
				arr.Add(new Point(i1, j1));
				k = i1;
				i1 = dadi[i1, j1];
				if (i1 == -2) break;
				j1 = dadj[k, j1];
			}
			return arr;
		}

		public static ArrayList checkLines(int[,] a, int iCenter, int jCenter)
		{
			ArrayList list = new ArrayList();

			int[] u = { 0, 1, 1, 1 };
			int[] v = { 1, 0, -1, 1 };
			int i, j, k;
			for (int t = 0; t < 4; t++)
			{
				k = 0;
				i = iCenter;
				j = jCenter;
				while (true)
				{
					i += u[t];
					j += v[t];
					if (!isInside(i, j))
						break;
					if (a[i, j] != a[iCenter, jCenter])
						break;
					k++;
				}
				i = iCenter;
				j = jCenter;
				while (true)
				{
					i -= u[t];
					j -= v[t];
					if (!isInside(i, j))
						break;
					if (a[i, j] != a[iCenter, jCenter])
						break;
					k++;
				}
				k++;
				if (k >= 5)
					while (k-- > 0)
					{
						i += u[t];
						j += v[t];
						if (i != iCenter || j != jCenter)
							list.Add(new Point(i, j));
					}
			}
			if (list.Count > 0) list.Add(new Point(iCenter, jCenter));
			else list = null;
			return list;
		}

		public static ArrayList merge(ArrayList l1, ArrayList l2)
		{
			foreach (Point p in l2)
				if (!checkExist(l1, p))
					l1.Add(p);
			return l1;
		}

		public static bool checkExist(ArrayList l, Point p)
		{
			foreach (Point pp in l)
				if (pp.X == p.X && pp.Y == p.Y)
					return true;
			return false;
		}

		public static bool isInside(int i, int j)
		{
			return (i >= 0 && i < 9 && j >= 0 && j < 9);
		}

	}
}
