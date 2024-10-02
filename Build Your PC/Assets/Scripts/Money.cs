using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using System;

public class Money : MonoBehaviour
{
    private int coins;
    public TMPro.TextMeshProUGUI coinsText;

    //public TMPro.TextMeshProUGUI price;

/*    private void Start()
    {
        coinsText = FindObjectOfType<TextMeshProUGUI>();
    }*/

    private void OnEnable()
    {
        if (GlobalVar.coins != 0)
        {
            coins = GlobalVar.coins;
            coinsText.text = coins.ToString();
        }

    }

    private void OnDestroy()
    {
        GlobalVar.coins = coins;
    }

    private TMP_Text price;
    public void BuyItem()
    {
        GameObject priceObj = GameObject.Find("price");
        price = priceObj.GetComponent<TMP_Text>();
        Debug.Log(price.text);
        string h = price.text.ToString().Substring(0, price.text.ToString().Length-1);
        coins -= Convert.ToInt32(h);
        coinsText.text = coins.ToString();
    }

    public void GetReward()
    {
        coins += 1500;
        coinsText.text = coins.ToString();

    }
}