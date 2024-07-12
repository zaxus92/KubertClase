using UnityEngine;
using System.Collections;

public class cntrlBotones : MonoBehaviour 
{
	public void cargarEscena1 ()
	{
		Application.LoadLevel("escena1");
	}

	public void cargarEscena2 ()
	{
		Application.LoadLevel("escena2");
	}

	public void cargarEscena3 ()
	{
		Application.LoadLevel("escena3");
	}

	public void cargarEscena4 ()
	{
		Application.LoadLevel("escena4");
	}

	public void cargarPrincipio ()
	{
		Application.LoadLevel("escena0_start");
	}
}
