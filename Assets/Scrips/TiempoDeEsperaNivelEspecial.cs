using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiempoDeEsperaNivelEspecial : MonoBehaviour
{
    public Text txtTime;
    public float hora;
    public float minutos;
    float msToWait;
    public bool isFin = false;
    public string retencionName;
    private ulong inicioTimer;
    float segundosRestantes = 0.0f;
    bool habilitarBoton = false;
    public GameObject boton;

    private void Awake()
    {
        if (PlayerPrefs.HasKey(retencionName))
        {
            long aux = long.Parse(PlayerPrefs.GetString(retencionName));
            if (aux < 0) isFin = true;
            else
            {
                inicioTimer = (ulong)aux;
                ConvertirTimeToMs();
            }
        }
        else
        {
            IniciarTimer();
        }
    }

    public void IniciarTimer()
    {
        ConvertirTimeToMs();
        inicioTimer = (ulong)System.DateTime.Now.Ticks;
        PlayerPrefs.SetString(retencionName, inicioTimer.ToString());
        isFin = false;
    }
    void ConvertirTimeToMs()
    {
        float aux = (hora * 60.0f) + minutos;
        msToWait = aux * 60000.0f;
    }

    private void Start()
    {
        boton.GetComponent<Button>().interactable = false;
    }

    private void Update()
    {
        segundosRestantes = SaberTotalSegundos();
        if (TimerFinalizado())
        {
            txtTime.text = "NIVEL ESPECIAL DESBLOQUEADO";
            boton.GetComponent<Button>().interactable = true;
            return;
        }
        
        
        string auxTimer = "";

        auxTimer += ((int)segundosRestantes / 3600).ToString() + "h";
        segundosRestantes -= ((int)segundosRestantes / 3600) * 3600;

        auxTimer += ((int)segundosRestantes / 60).ToString("00") + "m";

        auxTimer += (segundosRestantes % 60).ToString("00") + "s";
        txtTime.text = auxTimer;
    }

    float SaberTotalSegundos()
    {
        ulong diff = ((ulong)System.DateTime.Now.Ticks - inicioTimer);
        ulong aux = diff / System.TimeSpan.TicksPerMillisecond;

        return (float)(msToWait - aux) / 1000.0f;
    }
    public bool TimerFinalizado()
    {
        if (segundosRestantes < 0)
        {
            isFin = true;
            PlayerPrefs.SetString(retencionName, "-1");
            return true;
        }
        return false;
    }
}
