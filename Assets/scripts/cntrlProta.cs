using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cntrlProta : MonoBehaviour 
{
	private Rigidbody rb; //definimos la variable en donde va a ir el rigidbody como una variable rigidboddy

	public float velocity;
	public Text puntosAmarillos;
	public Text puntosVerdes;
	public Text puntoRosa;

	GameObject DatosGlobales;
	cntrlDatosGlobales cDG;

	void Start ()
	{
		rb = GetComponent<Rigidbody>() as Rigidbody; //y en el start sacamos el componente del unity y se la asignamos a rb, luego le digo que as rigidbody para que le quede claro, porsiacaso

		DatosGlobales = GameObject.Find("DatosGlobales");
		cDG = DatosGlobales.GetComponent<cntrlDatosGlobales>();

		cDG.iPuntuacionAmarilla = 0;
	}

	void FixedUpdate ()
	{
		float moverHorizontal = Input.GetAxis ("Horizontal"); //
		float moverVertical = Input.GetAxis ("Vertical");

		Vector3 moovimiento = new Vector3 (moverHorizontal, 0.0f, moverVertical);

		rb.AddForce (moovimiento * velocity);
	}

	void OnTriggerEnter (Collider coli)
	{
		//Destroy(coli.gameObject);

		if (coli.gameObject.CompareTag("monedaAmarilla"))
		{
			coli.gameObject.SetActive(false);
			cDG.iPuntuacionAmarilla ++;
			sumarAmarillos();
		}

		/*if (coli.gameObject.CompareTag("monedaVerde"))
		{
			coli.gameObject.SetActive(false);
			cDG.iPuntuacionVerde ++;
			sumarPuntosEnTextoOAlgoAsi();
		}

		if (coli.gameObject.CompareTag("monedaRosa"))
		{
			coli.gameObject.SetActive(false);
			cDG.iPuntuacionRosa ++;
			sumarPuntosEnTextoOAlgoAsi();
		}*/
	}

	void sumarAmarillos ()
	{
		puntosAmarillos.text = "x " + cDG.iPuntuacionAmarilla.ToString ();
	}
}