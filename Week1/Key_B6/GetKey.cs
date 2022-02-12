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
         
        각 입력은 모두 3가지로 구분

        Down : 눌렀을 때

        Stay : 누르고 있을 때
        
        Up : 땠을 때
         
         */

        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("아이템을 구입하였습니다.");
        }

        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 이동중");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽 이동을 멈추었습니다.");
        }


        // 마우스

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("미사일 발사!");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("미사일 모으는 중 ... ");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("슈퍼 미사일 발사!");
        }

        // 매개변수로 사용된 0 대신에 (마우스 왼쪽 키 의미)
        // "Jump" 문자열 사용 가능 -> space 키 의미한다. 
        // Edit -> project setting -> input manager에서 확인 가능 
    }

}
