using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    private int coins;
    public TextMeshProUGUI coinsText;

    // function to inc coin amount
    public void AddCoins(int num) {
        coins += num;
        coinsText.text = "COINS: " + coins;
    }
}
