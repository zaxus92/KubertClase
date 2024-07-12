using UnityEngine;
using System.Collections;

public class cntrlEnemigo : MonoBehaviour 
{
	void OnCollisionEnter (Collision coli)
	{
		if (coli.gameObject.name == "prota")
		{
			Application.LoadLevel ("escena1");
		}
	}
}
