using System;

public static class UString
{
	public static int ToInt(this string s)
	{
		return int.Parse (s);
	}

	public static int ToInt(this string s, int def)
	{
		int i = def;
		if (int.TryParse (s, out i))
			return i;
		return def;

	}

	public static float ToFloat(this string s)
	{
		return float.Parse (s);
	}

	public static float ToFloat(this string s, float def)
	{
		float i = def;
		if (float.TryParse (s, out i))
			return i;
		return def;
	}

	public static double ToDouble(this string s)
	{
		return double.Parse (s);
	}

	public static double ToDouble(this string s, double def)
	{
		double i = def;
		if (double.TryParse (s, out i))
			return i;
		return def;

	}

	public static string Format(this string s, params object[] args)
	{
		return string.Format (s, args);
	}


}


