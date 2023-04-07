using UnityEngine;

namespace DefaultNamespace.UI
{
    [CreateAssetMenu(menuName = nameof(LevelsConfigs))]
    public class LevelsConfigs : ScriptableObject
    {
        public LevelConfig[] Levels => _levels;
        
        [SerializeField] private LevelConfig[] _levels;
    }
}