using System;
using UnityEngine;

public static class StringExtensions 
{
	// convert a string hex value to a Color32 value

	public static Color32 ToColor(this string HexVal)
	{
		int IntVal = Convert.ToInt32(HexVal, 16);

		byte R = (byte)((IntVal >> 24) & 0xFF);
		byte G = (byte)((IntVal >> 16) & 0xFF);
		byte B = (byte)((IntVal >> 8) & 0xFF);

		return new Color32(R, G, B, 255);
	}
}