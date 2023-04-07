using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DefaultNamespace.UI
{
    public class LevelButton : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _numberText;
        [SerializeField] private Button _button;
        private string _sceneName;
        
        public void DrawLevel(string levelNumber, string sceneName, bool active)
        {
            _numberText.text = levelNumber;
            _sceneName = sceneName;

            _button.interactable = active;
            
            _button.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            SceneManager.LoadSceneAsync(_sceneName);
        }
    }
}