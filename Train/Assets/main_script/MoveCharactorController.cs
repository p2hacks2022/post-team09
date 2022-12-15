using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MoveCharactorController : MonoBehaviour
{
    Rigidbody2D rb;
    private float speed;
    private float input;
    private bool isRight;
    Animator anim;
 
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        speed = 1.5f;
    }
 
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(input* speed, rb.velocity.y);
 
        //Runのアニメーション
        if(input != 0)
        {
            anim.SetBool("isWalk", true);
        }
        else
        {
            anim.SetBool("isWalk", false);
        }
 
        //向きを変える
        if(input > 0)
        {
            transform.eulerAngles = new Vector3(0,0,0);
            isRight = true;
        }
        else if(input < 0)
        {
            transform.eulerAngles = new Vector3(0,180,0);
            isRight = false;
        } 
    }
}