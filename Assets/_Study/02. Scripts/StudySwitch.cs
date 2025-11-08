using System;
using UnityEngine;

public class StudySwitch : MonoBehaviour
{
    public enum MonsterState { Idle, Patrol, Trace, Attack, Retreat }
    public MonsterState currentState;

    public int hp = 100;

    void Start()
    {
        // Invoke("OnLog", 3f); // 3초후 실행
        
        Invoke("CancelMethod", 5f);
        
        InvokeRepeating("OnLog", 3f, 1f); // 3초후 실행, 1초마다 반복

    }

    public void OnLog()
    {
        Debug.Log("Hello World");
    }

    public void CancelMethod()
    {
        CancelInvoke("OnLog");
    }
    
    void Update()
    {
        if (hp <= 0)
            return;

        switch (currentState)
        {
            case MonsterState.Idle:
                // 가만히 있는 기능
                // 주변의 플레이어와의 거리를 측정하는 기능
                break;
            case MonsterState.Patrol:
                // 주변을 돌아다니는 기능
                // 주변의 플레이어와의 거리를 측정하는 기능
                break;
            case MonsterState.Trace:
                // 플레이어를 타겟으로 설정
                // 타겟을 향해 이동하는 기능
                break;
            case MonsterState.Attack:
                // 공격을 하는 기능
                // 공격 쿨다운 도는 기능
                break;
            case MonsterState.Retreat:
                // 플레이어와의 반대 방향으로 이동하는 기능
                break;
        }
    }
}