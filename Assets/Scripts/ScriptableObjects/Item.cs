namespace ScriptableAssets
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Item", menuName = "Items/Consumable",
    order = 3)]
    public class Item : ScriptableObject
    {
        public string Name;
    }
}