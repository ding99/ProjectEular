﻿/*
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"
Write the code that will take a string and make this conversion given a number of rows:
string convert(string s, int numRows);
*/

using System;
using System.Text;

namespace LeetCode.Leet01_10 {
	public class ZigZag {
		public void Start() {
			Convert("PAYPALISHIRING", 3);
			Convert("PAYPALISHIRING", 4);
			Convert("A", 1);
		}

		private void Convert(string s, int numRows) {
			Console.WriteLine($"Input: s = \"{s}\", numRows = {numRows}");
			string converted = s;
			if (numRows > 1) {
				StringBuilder b = new StringBuilder();
				int size = s.Length, step = numRows * 2 - 2; ;

				for (int i = 0; i < numRows; i++) {
					for (int j = 0; j < size; j += step) {
						if (j + i < size) b.Append(s[j + i]);
						if (i > 0 && i + 1 < numRows && j + numRows * 2 < size + i + 2)
							b.Append(s[j + numRows * 2 - i - 2]);
					}
				}

				converted = b.ToString();
			}

			Console.WriteLine($"Output: \"{converted}\"");
		}
	}
}
