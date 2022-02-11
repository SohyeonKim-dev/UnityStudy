using UnityEngine;

public class lifecycle : MonoBehaviour
{
    // 초기화
    void Awake()
    {
        Debug.Log("Player's data is ready.");
    }


    // object 켜기(활성화)
    void OnEnable()
    {
        Debug.Log("플레이어가 로그인 했습니다. ");
    }


    void Start()
    {
        Debug.Log("I got my hunting gear.");
    }


    // 물리 연산 업데이트 함수
    // 고정된 실행 주기로 CPU 부하 발생
    // 1초에 약 50회 호출

    void FixedUpdate()
    {
        Debug.Log("Moving~");
    }

    void Update()
    {
        Debug.Log("Monster Hunting!");
    }

    void LateUpdate()
    {
        Debug.Log("경험치 획득! :) ");
        // 카메라, 후처리 담당
    }



    // 오브젝트 비활성화

    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃 했습니다. ");
    }

    void OnDestroy()
    {
        Debug.Log("Frees the player's data.");
    }
}
