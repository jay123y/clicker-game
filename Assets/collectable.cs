using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    private void OnMouseDown(){
        mvbox script = transform.GetComponent<mvbox>();
        script.maxClick -=1;
        if (script.maxClick <= 0){
            Destroy(gameObject);
        }else{
            script.GetrandomPosition();
        }
    }
}
