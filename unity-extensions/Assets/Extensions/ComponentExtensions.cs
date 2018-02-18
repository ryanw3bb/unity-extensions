using UnityEngine;

public static class ComponentExtensions 
{
	// add a component to a components gameobject

	public static T AddComponent<T>(this Component component) where T : Component
	{
		return component.gameObject.AddComponent<T>();
	}


	// get a component on gameobject or add one if it doesn't exist

	public static T AddOrGetComponent<T>(this Component component) where T : Component
	{
		return component.GetComponent<T>() ?? component.AddComponent<T>();
	}
}