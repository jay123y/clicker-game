using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    float waitTime =1f;
    float delay = 0f;
    public GameObject spawn;
    float screenSize;
    // Start is called before the first frame update
    void Start()
    {
        screenSize = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0f){
            delay = waitTime;
            float randX = UnityEngine.Random.Range(-screenSize * 2, screenSize * 2);
            float randY = UnityEngine.Random.Range(-screenSize, screenSize);
            int maxClick = UnityEngine.Random.Range(1, 10);
            spawn.GetComponent<mvbox>().maxClick = maxClick;
            Instantiate(spawn, new Vector2(randX, randY), transform.rotation);
        }
    }
}
