using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{

    public float speed;
    public float runSpeed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    public bool isLeftSide;
    public GameObject sprite;

    public Animator animator;
    SpriteRenderer st;

    public bool isHaveToy;
    public bool isGetNow;

    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Spin()
    {
        isLeftSide = !isLeftSide;
        sprite.transform.localScale = new Vector3(sprite.transform.localScale.x * -1f, sprite.transform.localScale.y, sprite.transform.localScale.z);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            runSpeed = (float)(1.5f - (gameObject.GetComponent<PlayerState>().dread * 0.01));
    
        }
        else
        {
            runSpeed = (float)(1 - (gameObject.GetComponent<PlayerState>().dread * 0.01));
        }

        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed * runSpeed;
    }

    private void FixedUpdate()
    {
        if(moveVelocity.x < 0f && !isLeftSide || moveVelocity.x > 0f && isLeftSide) {
            Spin();
        }
        if(moveInput.x != 0 || moveInput.y != 0)
        {
            animator.SetBool("isRun", true);
        }
        else
        {
            animator.SetBool("isRun", false);
        }
        rb.MovePosition(rb.position + moveVelocity * Time.deltaTime);
    }
}
