using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoulleteController : MonoBehaviour
{
   
   float rotSpeed = 0;                              // 룰렛 돌아가는 속도

    void Update()
    {
        if (Input.GetMouseButton(0))                // 마우스 왼쪽 버튼을 누르면
        {
            rotSpeed = 10;                          // 룰렛이 프레임 당 10의 속도로 돌아감
        }

        transform.Rotate(0,0,rotSpeed);             // 룰렛의 회전값음 0,0,룰렛속도 로 변경

        rotSpeed *= 0.99f;                          // 룰렛 속도 조절(느리게)
    }
}
