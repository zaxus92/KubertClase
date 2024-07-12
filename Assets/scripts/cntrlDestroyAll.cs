using UnityEngine;
using System.Collections;

public class cntrlDestroyAll : MonoBehaviour 
{
	void Start ()
	{
		Destroy (GameObject.Find ("DatosGlobales"));
		Destroy(GameObject.Find("Canvas"));
	}
}
