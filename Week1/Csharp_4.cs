using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");

        // 1. 변수

        int level = 5;
        float strength = 15.5f;
        string playerName = "브로콜리";
        bool isFullLevel = false;

        /*
        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);
        */

        // 2. 그룹형 변수

        string[] monsters = { "슬라임", "사막뱀", "악마" };

        /*
        Debug.Log("맵에 존재하는 몬스터!");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);
        */

        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        /*
        Debug.Log("맵에 존재하는 몬스터의 레벨은?");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);
        */

        // 리스트 생성 방법 (제네릭!)

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        /*
        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        // 삭제하는 방법 (index 로 접근!)
        items.RemoveAt(0);

        */

        // 3. 연산자

        int exp = 1500;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        /*
        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 총 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        */

        int nextExp = 300 - (exp % 300);
        // % -> 나머지 연산자 

        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        // 부등호 연산자 ( < , > , <= , >= )
        // 논리 연산자 ( &&, || )

        int health = 30;
        int mana = 25;
        bool isBadCondition = (health <= 50 && mana <= 20);
        // bool isBadCondition = (health <= 50 || mana <= 20);
        Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

        // 삼항 연산자
        // (조건) ? (조건이 true일 때 반환) : (조건이 false일 때 반환)

        string condition = isBadCondition ? "나쁨" : "좋음";

        // 4. 키워드
        //int, float, List, bool, new, string 등등 

        // 5. 조건문
        if (condition == "나쁨")
        {
            Debug.Log("용사의 상태가 나쁘니 아이템을 사용하세요!");
        }
        else
        {
            Debug.Log("용사의 상태가 좋습니다. :) ");
        }
        
        if(isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        if (isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }

        // 스위치문 (사막뱀의 경우에!)

        switch (monsterLevel[1])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터가 출현!");
                break;

            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;

            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;

            default:
                Debug.Log("??? 몬스터가 출현!");
                break;
        }


        // 6. 반복문

        while (health > 0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("독 데미지를 입었습니다!" + health);
            }
            else
            {
                Debug.Log("사망하였습니다.");
            }
            
            if(health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        // (연산 할 변수 ; 반복 조건; 연산 iter)
        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("붕대로 치료중 ... " + health);
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("이 지역에 있는 몬스터 :  " + monsters[index]);        
        }

        foreach(string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }
    }
}
