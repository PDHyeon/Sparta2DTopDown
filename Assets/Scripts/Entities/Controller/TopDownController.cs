using System;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    // 몬스터, 플레이어 등에 공통적으로 적용하기 위함.
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;

    protected bool IsAttacking { get; set; }

    private float timeSinceLastAttack = float.MaxValue;

    protected CharacterStatshandler stats { get; private set; }
    // protected 프로퍼티를 한 이유 : 나만 바꾸고 싶지만 가져가는 건 내 상속받는 클래스들도 볼 수 있게

    protected virtual void Awake()
    {
        stats = GetComponent<CharacterStatshandler>();
    }

    private void Update()
    {
        HandleAttackDelay();
    }

    private void HandleAttackDelay()
    {
        // TODO : MAGIC NUMBER 수정
        if(timeSinceLastAttack < stats.CurrentStat.attackSO.delay)
        {           
            timeSinceLastAttack += Time.deltaTime;
        }
        else if (IsAttacking && timeSinceLastAttack >= stats.CurrentStat.attackSO.delay) 
        {            
            timeSinceLastAttack = 0f;
            CallAttackEvent();
        }
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); // ? 없으면 말고 있으면 실행
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    private void CallAttackEvent()
    {
        OnAttackEvent?.Invoke();
    }
}
