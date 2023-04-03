using UnityEngine;

namespace DefaultNamespace
{
    public class Block : MonoBehaviour
    {
        [SerializeField] private int _hp = 5;

        public void Damage(int damage)
        {
            _hp-=damage;

            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}