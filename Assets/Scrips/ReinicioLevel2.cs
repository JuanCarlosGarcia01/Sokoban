using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReinicioLevel2 : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown("r"))
		{
			SceneManager.LoadScene("Nivel 2");
		}
	}
}
