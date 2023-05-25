using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
   
        public GameObject EnemyPrefab;
    float span = 1.0f;
    float delta = 0;


    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(EnemyPrefab);
            int px = Random.Range(10, 11);
            go.transform.position = new Vector3(px, 10 , 0);
        }
    }
}
