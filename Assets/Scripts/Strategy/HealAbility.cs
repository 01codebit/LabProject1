using UnityEngine;

namespace Strategy
{
    [CreateAssetMenu(fileName = "HealAbility", menuName = "LabProject1/Abilities/HealAbility")]
    public class HealAbility : BaseAbilitySO
    {
        public override void Use(GameObject currentGameObject)
        {
            Debug.Log("[HealAbility] Use");
        }
    }
}