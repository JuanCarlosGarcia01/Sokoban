using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text UIText;
    public float time = 0;

    private void Update()
    {
        time += Time.deltaTime;
        UIText.text = time.ToString("f0");
    }
}
