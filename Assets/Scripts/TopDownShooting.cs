using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

public class TopDownShooting : MonoBehaviour
{
    private TopDownController controller;

    [SerializeField] private Transform projectileSpawnPosition;
    private Vector2 aimDirection = Vector2.right;

    public GameObject testPrefab;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnAttackEvent += OnShoot;
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        aimDirection = direction;
    }

    private void OnShoot()
    {
        CreateProjectile();
    }

    // 투사체 만들기
    private void CreateProjectile()
    {
        // TODO : 날아가도록 수정해야 함.
        Instantiate(testPrefab, projectileSpawnPosition.position, Quaternion.identity);
    }
}
