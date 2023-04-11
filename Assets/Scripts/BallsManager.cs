using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public class BallsManager : MonoBehaviour
    {
        [SerializeField] private GameStateManager _gameStateManager;
        private HashSet<Ball> _balls = new HashSet<Ball>();
        
        public static BallsManager Instance => _instance;
        public static BallsManager _instance;

        private void Awake()
        {
            _instance = this;
            _balls = FindObjectsOfType<Ball>().ToHashSet();
        }

        public void DestroyBall(Ball ball)
        {
            Destroy(ball.gameObject);
            _balls.Remove(ball);

            if (_balls.Count == 0)
            {
                _gameStateManager.Lose();
            }
        }
    }
}