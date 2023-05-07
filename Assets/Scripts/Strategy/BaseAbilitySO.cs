using UnityEngine;

namespace Strategy
{
    public abstract class BaseAbilitySO : ScriptableObject, IAbility
    {
        public abstract void Use(GameObject currentGameObject);
    }
}