namespace ScriptableAssets
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Armor", menuName = "Items/Equipment/Armor", 
        order = 3)]

    public class Armor : Item
    { 
        public int DefenseBonus;
    }
}
