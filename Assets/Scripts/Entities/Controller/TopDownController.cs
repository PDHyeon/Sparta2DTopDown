using System;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    // ����, �÷��̾� � ���������� �����ϱ� ����.
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action<AttackSO> OnAttackEvent;

    protected bool IsAttacking { get; set; }

    private float timeSinceLastAttack = float.MaxValue;

    protected CharacterStatshandler stats { get; private set; }
    // protected ������Ƽ�� �� ���� : ���� �ٲٰ� ������ �������� �� �� ��ӹ޴� Ŭ�����鵵 �� �� �ְ�

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
        // TODO : MAGIC NUMBER ����
        if(timeSinceLastAttack < stats.CurrentStat.attackSO.delay)
        {           
            timeSinceLastAttack += Time.deltaTime;
        }
        else if (IsAttacking && timeSinceLastAttack >= stats.CurrentStat.attackSO.delay) 
        {            
            timeSinceLastAttack = 0f;
            CallAttackEvent(stats.CurrentStat.attackSO);
        }
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); // ? ������ ���� ������ ����
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    private void CallAttackEvent(AttackSO attackSO)
    {
        OnAttackEvent?.Invoke(attackSO);
    }
}
