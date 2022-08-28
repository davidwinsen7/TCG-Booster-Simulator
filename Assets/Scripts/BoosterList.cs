using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterList : MonoBehaviour
{
    public List<Card> ListOfCards;
    public List<int> numOfCards;//Respectively

    [HideInInspector] public List<Card> cardStash;

    private void Awake()
    {
        for(int i = 0; i < ListOfCards.Count; i++)
        {
            for(int j = 0; j < numOfCards[i]; j++)
            {
                cardStash.Add(ListOfCards[i]);
            }
        }
        Debug.Log(cardStash.Count);
    }
}
