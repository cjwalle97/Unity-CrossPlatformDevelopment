namespace ScriptableAssets
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Melee", menuName = "Items/Equipment/Melee",
        order = 3)]

    public class Melee : Item
    {
        public int AttackBonus;

        public int DefenseBonus;
    }
}
