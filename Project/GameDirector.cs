using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }

    
    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        distance.GetComponent<TextMeshProUGUI>().text = length.ToString("F2") + "m" + " to the target point";
    }
}
