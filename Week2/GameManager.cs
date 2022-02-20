using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // game manager의 역할: 점수 관리, 스테이지 이동을 관리

    public int totalPoint;
    public int stagePoint;
    public int stageIndex;

    public void NextStage()
    {
        stageIndex++;
        totalPoint += stagePoint;
        stagePoint = 0;
    }

    void Update()
    {
        
    }
}
