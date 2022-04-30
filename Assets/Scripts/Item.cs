using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        A,
        B,
        C,
        D
    }

    public ItemType itemType;

    public ItemType GetItemType()
    {
        return itemType;
    }

    public string ItemTypeString()
    {
        switch(itemType)
        {
            default: return "Other";
            case ItemType.A: return "A";
            case ItemType.B: return "B";
            case ItemType.C: return "C";
            case ItemType.D: return "D";
        }
    }

}