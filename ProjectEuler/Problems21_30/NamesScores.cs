﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

namespace Problems21_30
{
	public class NamesScores
	{
		private const string File = "DataEuler/p022_names.dat";
		private List<string> names;

		public NamesScores()
		{
			string row;
			Console.WriteLine($"path: {Paths.Paths.DataPath(File)}  / {File}");
			using (StreamReader sr = new StreamReader(Paths.Paths.DataPath(File)))
			{
				row = sr.ReadToEnd();
				sr.Close();
				sr.Dispose();
			}

			names = new List<string>();
			foreach (var a in row.Split(','))
				names.Add(a.Trim(new char[] { '"' }).ToUpper());
		}

		public void Start()
		{
			BigInteger scores = new BigInteger(0);
			int size = names.Count;

			names.Sort();

			for (int i = 0; i < size; i++)
				scores += Score(names[i]) * (i + 1);

			Console.WriteLine(scores); //871198282
		}

		private int Score(string name)
		{
			char[] chars = name.ToCharArray();
			int score = 0;
			foreach (char c in chars)
				score += c - 0x40;
			return score;
		}
	}
}
