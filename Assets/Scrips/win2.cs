using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class win2 : MonoBehaviour
{
    public GameObject objective2;
    public WinCondicion winCondition;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {

            objective2.GetComponent<SpriteRenderer>().color = Color.green;
            WinCondicion.PointWin++;

        }
    }
}

