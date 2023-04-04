using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace DefaultNamespace
{
     
    public class BlockManager : MonoBehaviour
    {
        [SerializeField] private GameStateManager _gameStateManager;
        [SerializeField] private int _damagePerHit = 1;
        private HashSet<Block> _blocks = new HashSet<Block>();

        private void Awake()
        {
            _blocks = FindObjectsOfType<Block>().ToHashSet();
        }

        public void DamageBlock(Block block)
        {
            block.Damage(_damagePerHit);

            if (block.IsDestroyed)
            {
                _blocks.Remove(block);
            }

            if (_blocks.Count == 0)
            {
                _gameStateManager.Win();
            }
        }
    }
}