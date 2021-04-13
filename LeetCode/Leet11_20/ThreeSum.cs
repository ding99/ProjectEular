﻿
/*
-- 3Sum
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets. 

-- 3Sum Closer
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Leet11_20 {
	public class ThreeSum {
		public void SumZero() {
			ActionZero(new int[] { -1,0,1,2,-1,-4});
		}

		private void ActionZero(int[] nums){
			int n = nums.Length;
			Console.Write("Input: nums = [");
			for (int i = 0; i < n; i++) Console.Write($"{nums[i]}{(i + 1 == n ? "]":",")}");
			Console.WriteLine();

			List<int[]> sums = new List<int[]>();
			int[] tri;

			if (n > 2)
				for (int i = 0; i + 2 < n; i++)
					for (int j = i + 1; j + 1 < n; j++)
						for (int k = j + 1; k < n; k++)
							if (nums[i] + nums[j] + nums[k] == 0 && !Contained(sums, tri = new int[] { nums[i], nums[j], nums[k] })) {
								Array.Sort(tri);
								sums.Add(tri);
							}

			int[][] arraySum = sums.ToArray();
			Console.Write("Output: [");
			for(int i = 0; i < arraySum.Length; i++) {
				Console.Write("[");
				for (int j = 0; j < arraySum[i].Length; j++)
					Console.Write($"{arraySum[i][j]}{(j + 1 == arraySum[i].Length ? "]" : ",")}");
				Console.Write(i + 1 == arraySum.Length ? "]" : ",");
			}
			Console.WriteLine();
		}

		private bool Contained(List<int[]> list, int[] element) {
			Array.Sort(element);
			Console.Write($"list size({list.Count}) <");
			foreach (var a in element) Console.Write($" {a}");
			Console.WriteLine(" >");
			foreach(int[] a in list)
				if(a.SequenceEqual(element)) return true;
			Console.WriteLine("-- false");
			return false;
		}
	}
}