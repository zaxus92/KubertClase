using UnityEngine;
using System.Collections;

public class cntrlTrigger : MonoBehaviour
{
	public Vector3 rotacionChachi2;
	cntrlCubo superCubo;

	void Start ()
	{
		GameObject sC = GameObject.FindWithTag("supercubo") as GameObject;
		superCubo = sC.GetComponent<cntrlCubo>() as cntrlCubo;
	}

	void OnTriggerEnter (Collider coli)
	{
		if (coli.gameObject.tag == "Player")
		{
			superCubo.rotacionChachi=rotacionChachi2;
		}
	}
}