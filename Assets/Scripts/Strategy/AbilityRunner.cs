using UnityEngine;

namespace Strategy
{
    public class AbilityRunner : MonoBehaviour
    {
        [SerializeField] BaseAbilitySO currentAbility;

        void Start()
        {
            Debug.Log("[AbilityRunner] Start");
            UseAbility();
        }

        public void UseAbility()
        {
            currentAbility?.Use(this.gameObject);
        }
    }
}
