using System;
using System.Collections.Generic;
namespace SimpleSAT
{
	public abstract class Clause: IComparable<Clause>
	{
		public int RemainingLiteralsForDecision  {
			get; protected set;
		}

		public int RemainingLiteralForConclusion {
			get; protected set;
		}

		/// <summary>
		/// Sets the literal. If the literal is negative, the literal is interpretet as false, otherwise true. The highest bit will be taken as vz.
		/// If the literal is already set and the given literal is not the same val as the setted literal the function will return false.
		/// </summary>
		/// <returns><c>true</c>, if literal was set, <c>false</c> otherwise.</returns>
		/// <param name="literal">Literal.</param>
		public abstract bool SetLiteral(int literal);

		public void SetLiterals(IEnumerable<int> literals) {
			foreach (var l in literals)
				SetLiteral (l); 				
		}

		public abstract void  UnSetLiteral (int literal);
 
		public void UnSetLiterals(IEnumerable<int> literals) {
			foreach (var l in literals)
				UnSetLiteral (l); 				
		}

		public int CompareTo(Clause c) {
			int ret = this.RemainingLiteralForConclusion.CompareTo (c.RemainingLiteralForConclusion);
			if (ret == 0) {
				ret = this.RemainingLiteralsForDecision.CompareTo (c.RemainingLiteralsForDecision);		
			}
			return ret;
		}

		public int[] AllLiterals { get; protected set; }

		public int HighestLiteral { get; protected set; }
	}

	public class Fact : Clause {
		Fact(int[] literalsIdx) {
			this.AllLiterals = literalsIdx;
			Array.Sort (AllLiterals);
			this.HighestLiteral = AllLiterals.Last ();
			this.RemainingLiteralsForDecision = AllLiterals.Length;
			this.RemainingLiteralForConclusion = 0;
		}

		public override bool SetLiteral(int literal) {
			int idx = Array.BinarySearch (AllLiterals, literal);
			if (idx < 0)
				return true;

			return AllLiterals [idx] == literal;
		}

		public override void UnSetLiteral (int literal)
		{
			// Nothing to do.
		}
	}

	public class Implication : Clause {
		int[] lHs, rHS;

	}

	public class ExactK : Clause {
	}

	public class MinK : Clause {
	}

	public class MaxK : Clause {
	}

	public class Or : Clause {
	}



}

