using UnityEngine;
using System.Collections;

public class cntrlCubo : MonoBehaviour {

	public Vector3 rotacionChachi;

	void Start ()
	{
		rotacionChachi = rotacionChachi + new Vector3 (0,0,0);
	}

	void FixedUpdate () 
	{
		transform.Rotate(rotacionChachi);
	}
}
