using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject timeGauge;
    GameObject meterText;
    float meter = 0;

    void Start()
    {
        this.timeGauge = GameObject.Find("timeGauge");
        this.meterText = GameObject.Find("meter");
    }
    void Update()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 0.0001667f;
        if (this.timeGauge.GetComponent <Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("TitleScene");
        }
        this.meter += Time.deltaTime*60;
        this.meterText.GetComponent<Text>().text = this.meter.ToString("F1") + "km";
    }

    public void Decreacetime()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 0.09f;
    }
}
