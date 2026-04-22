using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveX;
    private float moveY;
    public int speed = 5;
    [SerializeField] private Camera screenSpaceCamera;

    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        transform.position += new Vector3(moveX, moveY, 0) * Time.deltaTime * speed;

        Vector3 mousePos = Input.mousePosition;

        Vector3 worldPos = screenSpaceCamera.ScreenToWorldPoint(
            new Vector3(mousePos.x, mousePos.y, Mathf.Abs(screenSpaceCamera.transform.position.z))
        );

        Vector3 direction = worldPos - transform.position;
        direction.z = 0f;

        if (direction != Vector3.zero)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90f;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
    }
}