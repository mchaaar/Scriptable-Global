using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NewItem {

    public ScriptableItem item;
    public int customMinPrice;
    public int customMaxPrice;
    public bool useCustomPrices;

}

[CreateAssetMenu(menuName = "Scriptable Object/List/New List", fileName = "rename me")]
public class ScriptableItemList : ScriptableObject {

    [TextArea]
    [SerializeField]
    private string help = "Use the custom price bool & int if you intend to sell this item at another price \nthan the one defined in your ScriptableItem's item.";

    public List<NewItem> itemsSold = new List<NewItem>();
    public List<NewItem> itemsBought = new List<NewItem>();

}
