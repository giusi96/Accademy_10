using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unipi
{
	public class TriNode
	{
		public int key;
		public TriNode left, center, right;

		public TriNode(int k, TriNode l, TriNode c, TriNode r)
		{
			this.key = k;
			this.left = l;
			this.center = c;
			this.right = r;
		}

		public TriNode(int k) : this(k, null, null, null)
		{
			
		}

		public static TriNode f(int i)
		{
			return new TriNode(i);
		}

		public static TriNode n(int i, TriNode l, TriNode c, TriNode r)
		{
			return new TriNode(i, l, c, r);
		}

		public bool isFoglia()
		{
			return left == null && center == null && right == null;
		}

		public String toString()
		{
			StringBuilder s = new StringBuilder();
			pr1(this, s);
			return s.ToString();
		}

		private static void pr1(TriNode a, StringBuilder s)
		{
			if (a == null) return;
			s.Append(" (");
			s.Append(a.key + "");
			pr1(a.left, s);
			pr1(a.center, s);
			pr1(a.right, s);
			s.Append(") ");
		}

	}

}
