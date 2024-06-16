using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform Player;
    public float moveSpeed = 10f;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        //Initializing the position.
        Player.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //Player will stop when no Input is made.
        direction = Vector3.zero;

        //Directional controls.
        if (Input.GetKey(KeyCode.W))        //UP
        {
            direction.y += 1;
        }
        else if (Input.GetKey(KeyCode.A))   //LEFT
        {
            direction.x -= 1;
        }
        else if (Input.GetKey(KeyCode.S))   //DOWN
        {
            direction.y -= 1;
        }
        else if (Input.GetKey(KeyCode.D))   //RIGHT
        {
            direction.x += 1;
        }

        direction = direction.normalized;

        Player.position = Player.position + direction * moveSpeed * Time.deltaTime;

    }
}
