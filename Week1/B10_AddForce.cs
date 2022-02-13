using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_ball_first : MonoBehaviour
{
    Rigidbody rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.velocity = Vector3.right;
        // 초기 속력을 주는 방향 정하기

        //rigid.velocity = new Vector3(2, 4, 3);
        // 통통 튀긴다.
        // FixedUpdate (Update)에 넣으면 속도가 계속 유지되어 로켓처럼! 

        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        // 캐릭터가 점프할 때 사용
        // 물체의 mass에 영향을 받음
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
            //Debug.Log(rigid.velocity); // 속도 출력 가능
        }
        
        Vector3 vec = new Vector3(
                        Input.GetAxisRaw("Horizontal"),
                        0,
                        Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);


        // 회전력
        rigid.AddTorque(Vector3.back);
        // up, down 도 가능하다 (회전축을 설정하는 과정!)
        // 제자리에서 돌아간다 

    }
}
