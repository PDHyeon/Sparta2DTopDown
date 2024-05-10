using System;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatshandler : MonoBehaviour
{
    // 기본 스텟과 추가 스텟들을 계산해서 최종 스텟을 계산하는 로직이 있음

    [SerializeField] private CharacterStat baseStat;
    public CharacterStat CurrentStat { get; private set; }

    public List<CharacterStat> statModifiers = new List<CharacterStat>();

    private void Awake()
    {        
        UpdataCharacterStat();
    }

    private void UpdataCharacterStat()
    {
        AttackSO attackSO = null;
        if(baseStat.attackSO != null) 
        { 
            // 새로 생성함으로써 기존 attackSO가 아닌 다른 attackSO를 만듦
            attackSO = Instantiate(baseStat.attackSO);
        }

        CurrentStat = new CharacterStat { attackSO = attackSO };
        // TODO : 지금은 기본 능력치만 적용되지만, 앞으로는 능력치 강화 기능이 적용된다.
        CurrentStat.statsChangeType = baseStat.statsChangeType;
        CurrentStat.maxHealth = baseStat.maxHealth;
        CurrentStat.speed = baseStat.speed;
    }
}

