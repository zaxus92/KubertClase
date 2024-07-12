using UnityEngine;
using System.Collections;

public class cntrlGrupoMonedas : MonoBehaviour 
{
	GameObject [] aMonedasAmarillas;
	GameObject [] aMonedasVerdes;
	GameObject [] aMonedaRosa;

	void Start ()
	{
		aMonedasAmarillas = GameObject.FindGameObjectsWithTag("monedaAmarilla");
		aMonedasVerdes = GameObject.FindGameObjectsWithTag("monedaVerde");
		aMonedaRosa = GameObject.FindGameObjectsWithTag("monedaRosa");

		mostrarVerdes (false);
		mostrarRosa (false);
	}

	public bool comprobarAmarillasSuficientes ()
	{
		for (int i = 0; i < 5; i++)
		{
			if (aMonedasAmarillas[i].activeSelf)
			{
				return false; 
				print("The game is not over yet");
			}
			else
			{
				
			}
		}
		return true;
		print("But is almost ready");
	}

	public bool comprobarAmarillasVacias ()
	{
		for (int i = 0; i < aMonedasAmarillas.Length; i++)
		{
			if (aMonedasAmarillas[i].activeSelf)
			{
				return false; 
			}
			else
			{

			}
		}
		return true;
	}

	public bool comprobarVerdesVacias ()
	{
		for (int i = 0 ; i< aMonedasVerdes.Length; i++)
		{
			if (aMonedasVerdes[i].activeSelf)
			{
				return false;
			}
			else
			{

			}
		}
		Debug.Log ("Verdes vacias");
		return true;
	}

	public void mostrarVerdes (bool bMostrar)
	{
		for (int i=0; i<aMonedasVerdes.Length; i++)
		{
			aMonedasVerdes[i].SetActive(bMostrar);
		}
	}

	public void mostrarRosa (bool bMostrar)
	{
		for (int i=0; i<aMonedaRosa.Length; i++)
		{
			aMonedaRosa[i].SetActive(bMostrar);
		}
	}
}