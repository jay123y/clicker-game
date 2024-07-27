using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreboard : MonoBehaviour
{

    public int point;
    public int health = 2;
    public Text pointText;
    public GameObject ui;
    public void GetPoint(int amount){
    point += amount;
    pointText.text = point.ToString();
}
    public void TouchBomb(int amount){
        health -= amount;
        if (health <=0){
            ui.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void RestartGame(){
        SceneManager.LoadScene(0);
    }

}
