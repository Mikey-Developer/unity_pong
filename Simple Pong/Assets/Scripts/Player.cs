using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int player;
    public float speed;
    public Rigidbody2D rigidB;

    private float movement;

    private string controls;

    // Start is called before the first frame update
    void Start()
    {
        if(player == 1)
            controls = "Vertical";
        else
            controls = "Vertical2";
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw(controls);
        rigidB.velocity = new Vector2(rigidB.velocity.x, movement * speed);
    }
}
