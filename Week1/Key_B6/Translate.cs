using UnityEngine;

public class lifecycle : MonoBehaviour
{
  
    void Start()
    {
        //오브젝트는 transform을 기본적으로 가진다
        // Vector3 => 3차원 벡터를 의미한다.

        //Vector3 vec = new Vector3(5, 5, 5);
        //transform.Translate(vec);

        // Translate -> 이동한다
    }

    void Update()
    {
        //Vector3 vec = new Vector3(0, 0.1f, 0);
        //transform.Translate(vec);
        // 코드만으로 오브젝트를 이동시킬 수 있다.


        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0);
        transform.Translate(vec);
    }
}
