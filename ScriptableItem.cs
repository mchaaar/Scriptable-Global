using System.IO.Compression;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Item/New Item", fileName = "rename me")]
public class ScriptableItem : ScriptableObject {

    #region Enums

    public enum Rarity { Null, Common, Rare, Epic, Legendary, Other }

    public enum Dimension { Null, RealWorld, Other }

    public enum ItemType { Null, Consumable, Permanent, Weapon, Equipment, Cosmetic, Crafting, Fishing, House, Quest, Other }

    public enum ConsumableType { Null, Potion, Meal, Other }

    public enum Potion { Null, Heal, Defence, Attack, Speed, Other }

    public enum Meal { Null, Harvesting, Fishing, Charm, Sleep, Other }

    #endregion

    #region Common Variables

    [Space(5)]
    [Header("General :")]

    [Tooltip("Insert the id (identifier) for this item. Must be unique to that item.")]
    public int ID;

    [Space(3)]
    [Tooltip("Insert Item's Name.")]
    public new string name;

    [Space(3)]
    [TextArea]
    [Tooltip("Insert Item's Description.")]
    public string description;

    [Space(10)]
    [Tooltip("Insert the prefab of this item.")]
    public GameObject prefab;

    [Space(3)]
    [Tooltip("Insert the icon of this item.")]
    public GameObject icon;

    [Space(3)]
    [Tooltip("Defines the type of this item.")]
    public ItemType itemType;

    [Space(3)]
    [Tooltip("Defines in which dimension this item was made.")]
    public Dimension dimension;

    [Space(3)]
    [Tooltip("Defines how rare this item is.")]
    public Rarity rarity;

    [Space(5)]
    [Header("Inventory :")]
    [Space(15)]
    [Tooltip("Is this item allowed to be stacked ?")]
    public bool canBeStacked;
    [Tooltip("Insert the maximum amount of item allowed within one inventory slot.")]
    public int maxStack;

    [Space(5)]
    [Header("Trading :")]

    [Space(15)]
    [Tooltip("Is this item allowed to be bought ?")]
    public bool canBeBought;

    [Tooltip("Is this item allowed to be sold ?")]
    public bool canBeSold;

    [Space(15)]
    [Tooltip("Insert the min value at which you can buy this item.")]
    public int minBuyingValue;

    [Tooltip("Insert the max value at which you can buy this item.")]
    public int maxBuyingValue;

    [Space(15)]
    [Tooltip("Insert the min value at which you can sell this item.")]
    public int minSellingValue;

    [Tooltip("Insert the max value at which you can sell this item.")]
    public int maxSellingValue;

    #endregion

    #region Consumables

    [Space(5)]
    [Header("Consumables :")]
    [Space(10)]
    public ConsumableType Type;

    [Space(5)]
    [Header("Potion :")]
    [Space(5)]

    [Space(3)]
    [Range(0, 3)]
    public int potionLevel;

    [Space(3)]
    public Potion potionType;

    [Space(5)]
    [Header("Meal :")]
    [Space(10)]

    [Space(3)]
    [Range(0, 3)]
    public int mealLevel;

    [Space(3)]
    public Meal mealType;

    #endregion

    #region Plants

    [Space(5)]
    [Header("Plants :")]
    [Space(10)]

    [Space(3)]
    public int growthTime;

    [Space(3)]
    public bool destroyedOnceHarvested;

    [Space(3)]
    public int HarvestsBeforeDeath;

    #endregion

    #region Weapons

    [Space(5)]
    [Header("Weapons :")]
    [Space(10)]

    [Space(3)]
    public string weaponType;

    [Space(3)]
    public int weaponLevel;

    [Space(3)]
    public string weaponEffect;

    [Space(3)]
    public float weaponDamage;

    [Space(3)]
    public float weaponMaxDurabilty;

    [Space(3)]
    public bool needsAmmo;

    [Space(3)]
    public string ammoType;

    [Space(3)]
    public int ammoPerUsage;

    [Space(3)]
    public bool singleUseWeapon;

    #endregion

}
