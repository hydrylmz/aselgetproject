using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text EzelCoin;
    [SerializeField] private PlayerData playerData;
    

    void Start()
    {

        EzelCoin.text = "Ezel Coin: " + playerData.playerCoin;
    }

    private void Update()
    {
        EzelCoin.text = "Ezel Coin: " + playerData.playerCoin;
    }
}
