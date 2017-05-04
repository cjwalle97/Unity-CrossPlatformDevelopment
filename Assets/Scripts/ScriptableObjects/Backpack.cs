namespace ScriptableAssets
{
    using System.Collections.Generic;
    using UnityEngine;

    [CreateAssetMenu(fileName = "Backpack", menuName = "Backpack",
        order = 4)]

    public class Backpack : ScriptableObject
    {
        public string Name;

        public List<Item> ItemSlots;
    }
}
