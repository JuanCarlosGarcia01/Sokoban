using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReiniciarContadorDeNivelEspecial : MonoBehaviour
{
    public RetencionTimerButton scripTimer;

    public void BUTTON_REINICIAR()
    {
        scripTimer.iniciarTimer();
    }


}
