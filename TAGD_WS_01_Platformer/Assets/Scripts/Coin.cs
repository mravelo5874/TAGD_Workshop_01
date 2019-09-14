using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            Debug.Log("Coin!");
            PlayerManager pm = other.GetComponent<PlayerManager>();
            pm.AddCoins(1);
            Destroy(this.gameObject);
        }
    }
}
