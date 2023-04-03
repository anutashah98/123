using UnityEngine;

namespace DefaultNamespace
{
     
    public class BlockManager : MonoBehaviour
    {
        [SerializeField] private int _damagePerHit = 1;
        
        public void DamageBlock(Block block)
        {
            block.Damage(_damagePerHit);
        }
    }
}