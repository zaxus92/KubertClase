using UnityEngine;
using System.Collections;

public class cntrlMoneda : MonoBehaviour 
{
	void Update () 
	{
		transform.Rotate (new Vector3 (0, 265, 10) * Time.deltaTime);
	}

	/*void OnTriggerEnter (Collider coli)
	{
		if(coli.gameObject.tag == "Player")
		{
			GameObject grupoMonedas = GameObject.Find ("grupoMonedas");
			cntrlGrupoMonedas cGM = grupoMonedas.GetComponent<cntrlGrupoMonedas> ();

			if (gameObject.tag == "monedaAmarilla")
			{
				bool bAmarillasVacias;
				bAmarillasVacias = cGM.comprobarAmarillasVacias();

				if (bAmarillasVacias)
				{
					cGM.mostrarVerdes(true);
					Debug.Log ("Mostrando verdes, o al menos eso deberia");

					GameObject superCubo = GameObject.Find ("superCubo");
					cntrlCubo cSC = superCubo.GetComponent<cntrlCubo>();
					cSC.rotacionChachi = new Vector3 (0.6f, 1.2f, -0.8f);
				}
			}
		}
	}*/
}