// Activate and deactivate a GameObject.
// The GUI function implements two buttons.  These buttons
// toggle the attached GameObject.
// Note that this script needs to be attached to a
// GameObject that isn't disabled.

using UnityEngine;

public class Buttons : MonoBehaviour
{
	public GameObject GO;

	void OnGUI()
	{
		if (GUI.Button(new Rect(10, 10, 100, 30), "Enable"))
		{
			Debug.Log("Enable: " + GO.name);
			GO.SetActive(true);
		}
		if (GUI.Button(new Rect(10, 50, 100, 30), "Disable"))
		{
			Debug.Log("Disable: " + GO.name);
			GO.SetActive(false);
		}
	}
}