using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDelBotonEspecial : MonoBehaviour
{
    public RetencionTimerButton scripTimer;

    public void BUTTON_REINICIAR()
    {
        scripTimer.iniciarTimer();
    }


}
