namespace ScriptableAssets
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Item", menuName = "Items",
        order = 3)]

    public class Item : ScriptableObject
    {
        public string Name;

        public Sprite _sprite;

        public Type type;

        public Category category;
    }

    public enum Type
    {
        consumable,

        ammo,

        equipment,
    }

    public enum Category
    {
        none,

        melee,

        gun,

        armor
    }


}
