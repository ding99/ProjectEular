﻿/*
Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.
*/

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode.Leet21_30 {
	public class MergeLists {
		public void Start() {
			Action(new int[] { 1, 2, 4, }, new int[] { 1, 3, 4 });
		}

		private void Action(int[] l1, int[] l2) {
			Console.WriteLine($"Input:{Display(l1, "l1")},{Display(l2, "l2")}");

			SortedList<int, int> s1 = CreateList(new List<int>(l1));
			//Console.WriteLine(ShowSort(s1, "sorted list 1"));

			SortedList<int, int> s2 = CreateList(new List<int>(l2));
			//Console.WriteLine(ShowSort(s2, "sorted list 1"));

			List<int> mergelist = s1.Values.ToList();
			mergelist.AddRange(s2.Values.ToList());
			mergelist.Sort();
			SortedList<int, int> mergedSort = CreateList(mergelist);
			//Console.WriteLine(ShowSort(mergedSort, "merged list"));

			int[] merged = mergedSort.Values.ToArray();
			Console.WriteLine($"Output:{Display(merged, string.Empty)}");
		}

		private SortedList<int, int> CreateList(List<int> list) {
			SortedList<int, int>  sorted = new SortedList<int, int>();
			for (int i = 0; i < list.Count; i++)
				sorted.Add(i + 1, list[i]);
			return sorted;
		}

		private string ShowSort(SortedList<int, int> sorted, string name) {
			StringBuilder b = new StringBuilder();

			if (!string.IsNullOrEmpty(name))
				b.Append($"{name}:");
			foreach (var a in sorted)
				b.Append($"{a.Key}-{a.Value} ");
			return b.ToString();
		}

		private string Display(int[] nums, string name) {
			StringBuilder b = new StringBuilder();

			if(!string.IsNullOrEmpty(name))
				b.Append($" {name} =");
			b.Append(" [");

			int n = nums.Length;
			if(n > 0)
				for (int i = 0; i < n; i++) b.Append($"{nums[i]}{(i + 1 == n ? "" : ",")}");
			b.Append("]");

			return b.ToString();
		}

	}
}