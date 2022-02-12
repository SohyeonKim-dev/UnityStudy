using UnityEngine;

public class lifecycle : MonoBehaviour
{

    Vector3 target = new Vector3(8, 1.5f, 0);


    void Update()
    {
        /* 1. MoveTowards
  
        transform.position =
            Vector3.MoveTowards(transform.position, target, 1f);
        // 1f : 마지막 매개변수에 비례하여 이동 속도 증가
        */



        /* 2. SmoothDamp
         
        Vector3 velo = Vector3.zero;
        // Vector3 velo = Vector3.up * 50;

        transform.position =
            Vector3.SmoothDamp(transform.position, 
            target, ref velo, 1f);
        // 마지막 값을 적게 줄 수록 빠르게 움직인다.
        */



        /* 3. Lerp (선형 보간)
         
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);
        // 마지막 값을 적게 줄 수록 느리게 움직인다.

        */



         // 4. SLerp : 구면 선형 보간, 호를 그리며 이동
         
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);
                  
         
    }
}
