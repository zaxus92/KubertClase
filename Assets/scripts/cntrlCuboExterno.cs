using UnityEngine;
using System.Collections;

public class cntrlCuboExterno : MonoBehaviour 
{	
	void OnTriggerExit (Collider coli)
	{
		if (coli.gameObject.name == "prota")
		{
			Application.LoadLevel ("escenaX_gameOver");
		}
	}
}