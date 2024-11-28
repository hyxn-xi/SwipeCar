using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 0;                                        // 차의 이동 속도
    Vector2 startPos;                                       // 시작 위치
    void Update()
    {
        if(Input.GetMouseButtonDown(0))                     // 마우스 왼쪽 버튼을 누른 순간
        {
            startPos = Input.mousePosition;                 // 시작 위치에 마우스 위치 대입
        }
        else if(Input.GetMouseButtonUp(0))                  // 마우스 왼쪽 버튼에서 손을 뗀 순간
        {
            Vector2 endPos = Input.mousePosition;           // 종료 위치에 마우스 위치 대입
            float swipeLength = endPos.x - startPos.x;      // 스와이프 길이 = 종료 위치의 x좌표값 - 시작 위치의 x좌표값

            speed = swipeLength / 500.0f;                   // 속도 = 스와이프 길이를 500으로 나눈 값
            GetComponent<AudioSource>().Play();             // 오디오 소스 컴포넌트 가져와서 실행
        }

        transform.Translate(speed, 0, 0);                   // 위치 변경
        speed *= 0.99f;                                     // 속도 조절
    }
}
