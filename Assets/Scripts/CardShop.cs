using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardShop : MonoBehaviour
{
    public GameObject boosterPack;

    public GameObject buyButton;
    public GameObject clearButton;

    BoosterList cardList;
    public TextMeshProUGUI numOfPacks;
    private void Start()
    {
        cardList = FindObjectOfType<BoosterList>().GetComponent<BoosterList>();
        numOfPacks.text = (cardList.cardStash.Count / 3).ToString();
    }
    public void BuyPack()
    {
        if(cardList.cardStash.Count > 0)
        {
            numOfPacks.text = (int.Parse(numOfPacks.text) - 1).ToString();
            Instantiate(boosterPack, this.transform.position, this.transform.rotation);
            buyButton.SetActive(false);
            clearButton.SetActive(true);
        }
        else
        {
            Debug.Log("No more card to buy!");
        }
    }
    public void RemoveCards()
    {
        GameObject[] cards = GameObject.FindGameObjectsWithTag("Card");
        foreach(GameObject crd in cards)
        {
            GameObject.Destroy(crd);
        }
        buyButton.SetActive(true);
        clearButton.SetActive(false);
    }
}
