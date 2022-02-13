using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    // Start is called before the first frame update

    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;       
    }

    // private void OnCollisionEnter / Stay / Exit (충돌 시작, 충돌중, 끝)
    
    private void OnCollisionEnter (Collision collision)
    {

        mat.color = new Color(1, 1, 0);

        if (collision.gameObject.name == "MyBall_1")
        {
            mat.color = new Color(1, 0, 0);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        mat.color = new Color(1, 0, 1);
    }
}





/*  My ball에서 트리거로 인한 물리 충돌 효과


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_ball_first : MonoBehaviour
{
    Rigidbody rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();        
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    // OnTrigger 안에 쭉 머물러 있을 때
    {
        if (other.name == "Cube")
        {
            rigid.AddForce(Vector3.up * 200, ForceMode.Impulse);
            // Cube 내에서 위로 붕 뜨는 효과
        }
    }
}


*/
