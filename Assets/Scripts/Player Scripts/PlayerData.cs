using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int playerCoin = 0;

    public void AddCoins(int amount)
    {
        playerCoin += amount;
        Debug.Log("Player coins: " + playerCoin);
    }   


}
