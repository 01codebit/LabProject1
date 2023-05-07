using UnityEngine;

namespace Strategy
{
    [CreateAssetMenu(fileName = "RageAbility", menuName = "LabProject1/Abilities/RageAbility")]
    public class RageAbility : BaseAbilitySO
    {
        public override void Use(GameObject currentGameObject)
        {
            Debug.Log("[RageAbility] Use");
        }
    }
}