using UnityEngine;
using TMPro;

public class CircuitController : MonoBehaviour
{
	public bool switch1On = false;
	public bool switch2On = false;
	public UnityEngine.UI.Image bulb;
	public TextMeshProUGUI statusText;

	// Called when Switch 1 is clicked
	public void ToggleSwitch1()
	{
		switch1On = !switch1On;
		UpdateCircuit();
	}

	// Called when Switch 2 is clicked
	public void ToggleSwitch2()
	{
		switch2On = !switch2On;
		UpdateCircuit();
	}

	void UpdateCircuit()
	{
		// If BOTH switches are ON
		if (switch1On && switch2On)
		{
			bulb.color = Color.yellow;
			statusText.text = "Circuit Complete";
		}
		else
		{
			bulb.color = Color.gray;
			statusText.text = "Circuit Open";
		}
	}
}