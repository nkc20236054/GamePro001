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
    GameObject generator;
    float meter = 0;
    float time = 100f;

    void Start()
    {
        this.timeGauge = GameObject.Find("timeGauge");
        this.meterText = GameObject.Find("meter");
        this.generator = GameObject.Find("EnemyGenerator");
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
        this.time -= Time.deltaTime;
        if (this.time < 0)
        {
            this.time = 0;
            this.generator.GetComponent<EnemyGenerator>().SetParameter(10000.0f);
        }
        else if (0 <= this.time && this.time < 50)
        {
            this.generator.GetComponent<EnemyGenerator>().SetParameter(0.3f);
        }
        else if (50 <= this.time && this.time < 70)
        {
            this.generator.GetComponent<EnemyGenerator>().SetParameter(0.5f);
        }
        else if (70 <= this.time && this.time < 90)
        {
            this.generator.GetComponent<EnemyGenerator>().SetParameter(0.8f);
        }
        else if (90 <= this.time && this.time < 100)
        {
            this.generator.GetComponent<EnemyGenerator>().SetParameter(1.0f);
        }
    }

    public void Decreacetime()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 0.09f;
    }
}
