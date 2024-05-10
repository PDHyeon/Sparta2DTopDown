using System;
using UnityEngine;

public class TopDownAimRotation: MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    //이벤트 등록을 위해 추가
    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;    
    }

    void OnAim(Vector2 direction)
    {
        RotateArm(direction); 
    }

    private void RotateArm(Vector2 direction)
    {
        // 오일러에 넣어야 하기 때문에 변환
        float rotZ =  Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        armRenderer.flipY = Mathf.Abs(rotZ) > 90f;

        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
