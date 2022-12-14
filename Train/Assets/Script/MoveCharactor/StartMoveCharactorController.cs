using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMoveCharactorController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] GameObject panel;
    private Rigidbody2D body;
    private Animator anim;
    private Vector2 movement;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        panel.SetActive(false);
    }
    private void Update()
    {
        Transform myTransform = this.transform;

        // 座標を取得
        Vector3 pos = myTransform.position;

        //Vector3 posMap = MapMoveCharactorController.posMap;

        //movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        anim.SetBool("isWalk", movement != Vector2.zero);



        //Debug.Log(pos.x);
        if (pos.x <= -2.54)
        {
            movement.x = 1;
            //Debug.Log(posMap.x);
        }
        else
        {
            movement.x = 0;
            //Initiate.Fade("tyuuou_main 4", Color.black, 1.0f);
            //StartCoroutine(DelayCoroutine());
            StartCoroutine(DelayCoroutine());
            
        }


        if (movement != Vector2.zero)
        {
            anim.SetFloat("X", movement.x);
            anim.SetFloat("Y", movement.y);
        }

        
    }

    IEnumerator DelayCoroutine()
    {
            //transform.position = Vector3.one;

            // 3秒間待つ
            yield return new WaitForSeconds(1);

            panel.SetActive(true);

            // 3秒後に原点にワープ
            //transform.position = Vector3.zero;
    }

    private void FixedUpdate()
    {
        body.MovePosition(body.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

//はいいいえ表示
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Gate")
        {
            panel.SetActive(true);
        }
    }
}
