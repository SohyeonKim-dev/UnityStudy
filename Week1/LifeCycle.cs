using UnityEngine;

public class lifecycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Player's data is ready.");
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
}


// Bug 해결! 
// 앞에 두 줄 삭제하고, 물체에 적용하기
