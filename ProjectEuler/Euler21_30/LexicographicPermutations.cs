﻿using System;
using System.Collections.Generic;

namespace ProjectEuler.Euler21_30
{
	public class LexicographicPermutations
	{
		private List<int> p;

		public LexicographicPermutations()
		{
			p = new List<int> { 1 };
		}

		public void Start()
		{
			Creation();

			int source = 1000000 - 1, index;
			string result = string.Empty;
			List<int> digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			if (source < p[10])
				for (int i = 9; i >= 0; i--)
				{
					result += digits[index = source / p[i]];
					source %= p[i];
					digits.RemoveAt(index);
				}

			Console.WriteLine(string.IsNullOrEmpty(result) ? "Too big number" : result); //2783915460
		}

		private void Creation()
		{
			int value = 1;

			for (int i = 1; i < 11; i++)
				p.Add(value *= i);
		}
	}
}
