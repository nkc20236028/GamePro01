using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject TimeGauge;
    float time = 100f;
    // Start is called before the first frame update
    void Start()
    {
        this.TimeGauge = GameObject.Find("TimeGauge");
    }



    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;

      
        this.TimeGauge.GetComponent<Image>().fillAmount -= 0.01f;
        


        Debug.Log(time);




    }
}

