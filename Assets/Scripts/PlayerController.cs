using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement2D movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Movement2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.MoveToX();
        if (Input.GetMouseButton(0))
        {
            movement.MoveToY();
        }
    }
}