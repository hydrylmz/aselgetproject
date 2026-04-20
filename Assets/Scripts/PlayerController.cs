using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveX;
    private float moveY;
    public int speed = 5;
    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        //yol  = hız . zaman
        transform.position += new Vector3(moveX, moveY, 0) * Time.deltaTime * speed;
    }
}
