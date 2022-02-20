using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // game manager의 역할: 점수 관리, 스테이지 이동을 관리

    public int totalPoint;
    public int stagePoint;
    public int stageIndex;
    public int health;
    public PlayerMove player;

    public void NextStage()
    {
        stageIndex++;
        totalPoint += stagePoint;
        stagePoint = 0;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {            
            //Player Reposition
            if(health > 1)
            {
                collision.attachedRigidbody.velocity = Vector2.zero;
                collision.transform.position = new Vector3(0, 0, -1);
                // Error
            }

            //Health Down
            HealthDown();

        }
    }

    public void HealthDown()
    {
        if(health > 1)
        {
            health--;
        }
        else
        {
            //Player Die Effect
            player.OnDie();

            //Result UI
            Debug.Log("죽었습니다..! ㅠㅡㅜ");

            //Retry Button UI 
        }

    } 


}
