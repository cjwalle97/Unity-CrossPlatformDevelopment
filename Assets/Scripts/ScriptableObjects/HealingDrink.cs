namespace ScriptableAssets
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "HealingDrink", menuName = "Items/Consumable/HealingDrink",
    order = 3)]

    public class HealingDrink : Item
    {
        public int Recovery;
    }
}