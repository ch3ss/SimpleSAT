using System;

namespace SimpleSAT
{
	public static class Extensions
	{
		public static int CompareTo(this int val, int other) {
			return 0;
		}

		public static T Last<T>(this T[] array) {
			if (array == null)
				throw new ArgumentNullException ();
			if (array.Length == 0)
				throw new ArgumentException();

			return array [array.Length - 1];
		}
	}
}

