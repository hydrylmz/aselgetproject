using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;   

public class Coin : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerData>().AddCoins(1);
            FindObjectOfType<UIManager>().EzelCoin.text = "Ezel Coin: " + collision.gameObject.GetComponent<PlayerData>().playerCoin;
            Destroy(gameObject);
        }
    }

}
