using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    int pasos = 0;
    public Text pasosTexto;

    private void Start()
    {
        pasos = 0;
    }

    void Update()
    {
        pasosTexto.text = "Movimientos Realizados " + pasos;
    }

    public bool Move(Vector2 direction)
    {

        if (Mathf.Abs(direction.x) < 0.5)
        {
            direction.x = 0;
            pasos += 1;
        }
        else
        {
            direction.y = 0;
            pasos += 1;
        }
        direction.Normalize();
        if (Blocked(transform.position, direction))
        {

            return false;
        }
        else
        {
            transform.Translate(direction);
            return true;
        }
    }

    bool Blocked(Vector3 position, Vector2 direction)
    {
        Vector2 newPos = new Vector2(position.x, position.y) + direction;
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
        foreach (var wall in walls)
        {
            if (wall.transform.position.x == newPos.x && wall.transform.position.y == newPos.y)
            {
                return true;
            }
        }
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach (var box in boxes)
        {
            if (box.transform.position.x == newPos.x && box.transform.position.y == newPos.y)
            {
                Box bx = box.GetComponent<Box>();
                if (bx && bx.Move(direction))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        return false;
    }
}                       
                                            