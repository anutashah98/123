using DefaultNamespace.UI;
using UnityEngine;

namespace DefaultNamespace
{
    public class Block : MonoBehaviour
    {
        [SerializeField] private ElementName _elementName;
        [SerializeField] private int _hp = 3;

        public bool IsDestroyed { get; private set; } = false;

        public void Damage(int damage)
        {
            _hp-=damage;

            if (_hp <= 0)
            {
                Destroy(gameObject);
                IsDestroyed = true;
            }
        }
    }
}