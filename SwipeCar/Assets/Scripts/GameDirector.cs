using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                   // 유니티 내 UI 사용 시 추가
using TMPro;                            // 텍스트메쉬프로 사용 시 추가

public class GameDirector : MonoBehaviour
{
    GameObject car;                     // 게임 오브젝트 선언
    GameObject flag;
    GameObject distance;
    void Start()
    {
        car = GameObject.Find("car");                   // 선언한 게임 오브젝트에 실제 게임 오브젝트 찾아서 대입
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }

    
    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;                        // 화면에 표시되는 길이 = 깃발 x 위치 - 차 x 위치
        distance.GetComponent<TextMeshProUGUI>().text = length.ToString("F2") + "m" + " to the target point";
        // TMPUGUI 컴포넌트에 텍스트 추가(스크립트에서 텍스트 추가)
    }
}
