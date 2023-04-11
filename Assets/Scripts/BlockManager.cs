using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

namespace DefaultNamespace
{
     
    public class BlockManager : MonoBehaviour
    {
        [SerializeField] private GameStateManager _gameStateManager;
        [SerializeField] private int _damagePerHit = 1;
        private HashSet<Block> _blocks = new HashSet<Block>();

        public static BlockManager Instance => _instance;
        public static BlockManager _instance;

        private void Awake()
        {
            _instance = this;
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