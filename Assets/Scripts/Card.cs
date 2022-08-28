using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Card : ScriptableObject
{
    public enum Rarity
    {
        Normal,Rare,SuperRare,UltraRare
    }

    public string cardName;
    public Sprite FaceUpImage;
    public Rarity cardRarity = Rarity.Normal;
}
