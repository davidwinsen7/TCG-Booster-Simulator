using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    enum RARITY_TAG
    {
        Normal, Rare, SuperRare, UltraRare
    }
    public GameObject[] RarityTag;
    // Start is called before the first frame update
    void Start()
    {
        BoosterList cardList = FindObjectOfType<BoosterList>().GetComponent<BoosterList>();
        int index = Random.Range(0, cardList.cardStash.Count);
        this.GetComponent<SpriteRenderer>().sprite = cardList.cardStash[index].FaceUpImage;
        cardList.cardStash.RemoveAt(index);

        switch (cardList.cardStash[index].cardRarity)
        {
            case Card.Rarity.Normal:
                RarityTag[(int)RARITY_TAG.Normal].SetActive(true);
                break;
            case Card.Rarity.Rare:
                RarityTag[(int)RARITY_TAG.Rare].SetActive(true);
                break;
            case Card.Rarity.SuperRare:
                RarityTag[(int)RARITY_TAG.SuperRare].SetActive(true);
                break;
            case Card.Rarity.UltraRare:
                RarityTag[(int)RARITY_TAG.UltraRare].SetActive(true);
                break;
        }

        Debug.Log(cardList.cardStash.Count);
    }
}
