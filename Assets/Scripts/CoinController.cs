using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public static CoinController instance;

    private void Awake()
    {
        instance = this;
    }

    public int currentCoins;

    public CoinPickup coin;

    public void AddCoin(int coinsToAdd)
    {
        currentCoins += coinsToAdd;

        UIController.instance.UpdateCoins();
    }

    public void DropCoin(Vector3 position, int value)
    {
        CoinPickup newCoin = Instantiate(coin, position + new Vector3(0.2f, 0.1f, 0f), Quaternion.identity);
        newCoin.coinAmount = value;
        newCoin.gameObject.SetActive(true);
    }
}
