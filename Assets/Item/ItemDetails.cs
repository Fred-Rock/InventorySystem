using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    public int itemCode;
    public ItemType itemType;
    public string itemDescription;
    public Sprite itemSprite;
    public int cost;
    public string itemLongDescription;
    public bool isStartingItem;
    public bool canBePickedUp;
    public bool canBeDropped;
}