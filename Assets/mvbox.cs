using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mvbox : MonoBehaviour
{
    public float speed =2f;
    public int maxClick = 1;
    public float width;
    public float height;
    public Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        height = Camera.main.orthographicSize;
        width = Camera.main.orthographicSize * 2;
        GetrandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
    }

    public void GetrandomPosition(){
            float randX = Random.Range(-width, width);
        float randY = Random.Range(-height, height);
        targetPos = new Vector2(randX, randY);
    }
}
