namespace ScriptableAssets
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Gun", menuName = "Items/Equipment/Gun",
    order = 3)]

    public class Gun : Item
    {
        public int AttackBonus;

        public Ammo ammo;
    }
}