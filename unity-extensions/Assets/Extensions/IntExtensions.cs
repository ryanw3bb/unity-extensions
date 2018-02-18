using UnityEngine;

public static class IntExtensions 
{
	// convert 32-bit int to a Color32 value

	public static Color32 ToColor(this int IntVal)
	{
		byte R = (byte)((IntVal >> 24) & 0xFF);
		byte G = (byte)((IntVal >> 16) & 0xFF);
		byte B = (byte)((IntVal >> 8) & 0xFF);

		return new Color32(R, G, B, 255);
	}
}