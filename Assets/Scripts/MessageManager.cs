using System;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class MessageManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private GameStateManager _gameStateManager;

        private void Awake()
        {
            _gameStateManager.OnWin += PrintWin;
            _gameStateManager.OnLose += PrintLose;
        }

        private void PrintLose()
        {
            _text.text = "You lose!";
        }

        private void PrintWin()
        {
            _text.text = "You win!";
        }
    }
}