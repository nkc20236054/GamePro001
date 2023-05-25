using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject timeGauge;
    void Start()
    {
        this.timeGauge = GameObject.Find("timeGauge");
    }
    void Update()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 0.00028f;
        if (this.timeGauge.GetComponent <Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }

    public void Decreacetime()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 0.155f;
    }
}
