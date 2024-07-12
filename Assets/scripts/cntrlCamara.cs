using UnityEngine;
using System.Collections;

public class cntrlCamara : MonoBehaviour 
{
	public GameObject prota;

	private Vector3 offset; //sinceramente, lo de el offset y los transform.position + equilicua no lo he entendido

	void Start()
	{
		offset = transform.position - prota.transform.position;
	}

	void LateUpdate() //con lateupdate nos aseguramos de que, a pesar de que se ejecute una vez por cada fotograma, se ejecute despues de hacer todo lo demas
	{
		transform.position = prota.transform.position + offset;
	}
}
