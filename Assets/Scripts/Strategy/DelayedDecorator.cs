using System.Net.NetworkInformation;
using UnityEngine;

namespace Strategy
{
    [CreateAssetMenu(fileName = "DelayedDecorator", menuName = "LabProject1/Abilities/DelayedDecorator")]
    public class DelayedDecorator : BaseAbilitySO
    {
        [SerializeField] BaseAbilitySO wrappedAbility;

        public override void Use(GameObject currentGameObject)
        {
            // TODO: implement some kind of delay...
            wrappedAbility.Use(currentGameObject);    
        }
    }
}