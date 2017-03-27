using System;
using System.Collections.Generic;
using SimpleSAT;
namespace SimpleSAT
{
	public class SimpleSATSolver
	{
		private PriorityQueue<Clause> queue = new PriorityQueue<Clause>();
		private int highestLiteral;
		public SimpleSATSolver (IEnumerable<Clause> clauses)
		{
			foreach (var c in clauses) {
				queue.Enqueue (c);
				highestLiteral = Math.Max(highestLiteral, Math.Abs(c.HighestLiteral) + 1);
			}

		}

		public void solve() {

			Stack<Tuple<int, List<int>>> stack = new Stack<Tuple<int, List<int>>>();

			int[] counts = new int[highestLiteral];

			foreach (var c in queue.Data) {
			}
		}

		private int choose(int[] counts) {

			return 0;

		}

		private int[] absorb(Clause a, Clause b) {
			return null;
		}
			

	}
}

