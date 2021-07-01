using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondicion : MonoBehaviour
{
    public static int PointWin = 0;

    private void Update()
    {
        if (PointWin == 1)
        {
            //    SceneManager.LoadScene("Nivel 2");
            Debug.Log("Funciona");
        }
    }
}
