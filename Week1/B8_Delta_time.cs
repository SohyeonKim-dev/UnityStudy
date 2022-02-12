using UnityEngine;

public class lifecycle : MonoBehaviour
{

    void start()
    {

    }


    void Update()
    {

        /*  Time.deltaTime 사용법



            1. Translate: 벡터에 곱하기

            transform.Translate(Vec * Time.deltaTime);

            2. Vector 함수: 시간 매개변수에 곱하기

            Vector3.Slerp(vec1, vec, T * Time.deltaTime);



        */


        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime,
            0);

        transform.Translate(vec);

                  
         
    }
}
