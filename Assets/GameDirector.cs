using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject TimeGauge;
    float time = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.TimeGauge = GameObject.Find("TimeGauge");
    }

   

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        
        this.TimeGauge.GetComponent<Image>().fillAmount = this.time;
    }
}
