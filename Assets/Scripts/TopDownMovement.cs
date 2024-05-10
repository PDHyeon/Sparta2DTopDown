using UnityEngine;
using UnityEngine.UI;

public class TopDownMovement : MonoBehaviour
{
    //실제로 이동이 일어날 컴포넌트

    private TopDownController controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private Animator animator;

    private void Awake()
    {
        // 주로 내 컴퍼넌트 안에서 끝나는 거

        //controller랑 TopdownMovement랑 같은 게임오브젝트 안에 있다라는 가정
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;   
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction; 
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
        Camera.main.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -10f);

        if (direction == Vector2.zero)
        {
            animator.SetBool("IsMove", false);
        }
        else
        {
            animator.SetBool("IsMove", true);
        }
    }
}
