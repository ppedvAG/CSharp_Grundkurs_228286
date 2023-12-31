﻿namespace M012;

public static class ExtensionMethods
{
	public static int Quersumme(this int x) //hier mit this auf einen Typen beziehen
	{
		return x.ToString().Sum(e => (int) char.GetNumericValue(e));
	}

	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> x)
	{
		return x.OrderBy(e => Random.Shared.Next());
	}
}
