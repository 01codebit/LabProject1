using UnityEngine;

namespace Strategy
{
    public interface IAbility
    {
        void Use(GameObject currentGameObject);
    }
}