using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{       
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }


    // 물리 연산 업데이트 함수
    // 고정된 실행 주기로 CPU 부하 발생
    // 1초에 약 50회 호출

    void FixedUpdate()
    {
        Debug.Log("이동~");
    }

}
