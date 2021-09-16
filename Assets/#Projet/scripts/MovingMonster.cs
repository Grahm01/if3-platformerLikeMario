using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMonster : Monster
{
    [Tooltip("Monster speed")]
    public Vector2 speed = Vector2.zero;

    private SpriteRenderer spriteRenderer;
    public bool flipX;

    [Tooltip("if an obstacle is at distence equal or less, the sprite flips")]
    public float hitRange = 0.1f;

    private Animator animator;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    virtual protected void Update()
    {
        Vector2 start;
        Vector2 direction;

        if (speed.x < 0)
        {
            if (animator != null)
            {
                animator.SetBool("Right", false);
            }

            else
            {
                spriteRenderer.flipX = true;
            }
            spriteRenderer.flipX = true;
            start = (Vector2)transform.position + Vector2.left * 0.51f;
            direction = Vector2.left;

        }
        else {

            if (animator != null)
            {
                animator.SetBool("Right", true);
            }

            else
            {
                spriteRenderer.flipX = true;
            }

            spriteRenderer.flipX = false;
            start = (Vector2)transform.position + Vector2.right * 0.51f;
            direction = Vector2.right;
        }

        Debug.DrawRay(start, direction * hitRange, Color.cyan);
        RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange);

        

        //deplacement
        Vector2 deplacement = speed  * Time.deltaTime;
        transform.position += (Vector3)deplacement;

        if(hit.collider != null)
        {
            speed.x *= -1;
        }


        //Debug.DrawRay(transform.position, Vector2.right *100, Color.cyan);
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);
    }
}
