using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour {

	public List<GameObject> pickUps;
	public void ResetPickUps()
	{
		foreach (GameObject pickUp in pickUps)
		{
			pickUp.SetActive(true);
		}
	}
}
