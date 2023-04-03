using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private BlockManager _blockManager;
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            // var otherBlock = collision.transform.GetComponent<Block>();
            // if (otherBlock == null) return;

            if (collision.transform.TryGetComponent<Block>(out Block otherBlock))
            {
                _blockManager.DamageBlock(otherBlock);
            }
        }
    }
}