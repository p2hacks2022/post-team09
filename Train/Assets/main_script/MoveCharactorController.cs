using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharactorController : MonoBehaviour
{
    private float speed = 0.005f;
    private SpriteRenderer renderer;

    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("a"))
        {
            position.x -= speed;
            renderer.flipX = true;
            
        }
        else if (Input.GetKey("d"))
        {
            position.x += speed;
            renderer.flipX = false;
        }
        else if (Input.GetKey("w"))
        {
            position.y += speed;
        }
        else if (Input.GetKey("s"))
        {
            position.y -= speed;
        }

        transform.position = position;
    }
}
