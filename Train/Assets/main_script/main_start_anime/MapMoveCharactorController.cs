using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MapMoveCharactorController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] GameObject panel;
    private Rigidbody2D body;
    private Animator anim;
    private Vector2 movement;
    //public static Vector3 posMap;
    //public static Transform mapTransform;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        panel.SetActive(false);
        //mapTransform = this.transform;

        // ç¿ïWÇéÊìæ
       // posMap = mapTransform.position;
    }
    private void Update()
    {
        

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        anim.SetBool("isWalk", movement != Vector2.zero);
        if (movement != Vector2.zero)
        {
            anim.SetFloat("X", movement.x);
            anim.SetFloat("Y", movement.y);
            //Debug.Log(movement.x);
        }
    }
    private void FixedUpdate()
    {
        body.MovePosition(body.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    //ÇÕÇ¢Ç¢Ç¢Ç¶ï\é¶
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Gate")
        {
            panel.SetActive(true);
        }
    }
}