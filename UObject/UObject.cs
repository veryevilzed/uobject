using System;

public static class UObject
{
	public static bool IsString(this object o)
	{
		return o.GetType () == typeof(string);
	}

	public static bool IsInt(this object o)
	{
		return o.GetType () == typeof(int);
	}

	public static bool IsFloat(this object o)
	{
		return o.GetType () == typeof(int);
	}

	public static bool IsArray(this object o)
	{
		return o.GetType ().IsArray;
	}

	public static bool IsArrayOf<T>(this object o)
	{
		return o.GetType () == typeof (T[]);
	}

	public static bool IsType<T>(this object o)
	{
		return o.GetType () == typeof(T);
	}

}

