using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private GameObject gemPrefab;
    [SerializeField] private Canvas canvas;

    public void Destroy()
    {
        Debug.Log("Box destroyed!");
        if(canvas == null)
        {
            canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        }
        Instantiate(gemPrefab, transform.position,Quaternion.identity,canvas.transform);
    }
}
