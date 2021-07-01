using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManajer : MonoBehaviour
{
    private bool m_readyForInput;
    public Player m_player;


    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveInput.Normalize();
        if (moveInput.sqrMagnitude > 0.5)
        {
            if (m_readyForInput)
            {
                m_readyForInput = false;
                m_player.Move(moveInput);
            }
        }
        else
        {
            m_readyForInput = true; 
        }

    }

    


}
