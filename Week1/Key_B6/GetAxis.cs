using UnityEngine;

public class lifecycle : MonoBehaviour
{
  
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }

        /*
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중 ..." 
                + Input.GetAxis("Horizontal"));
        }

        // float 개념

        */

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중 ..."
                + Input.GetAxisRaw("Horizontal"));
        }
        // Raw -> 1 or -1 (right/left)

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중 ..."
                + Input.GetAxisRaw("Vertical"));
        }
    }

}
