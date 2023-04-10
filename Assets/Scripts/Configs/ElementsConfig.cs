using UnityEngine;

namespace DefaultNamespace.UI
{
    [CreateAssetMenu(menuName = nameof(ElementsConfig))]
    public class ElementsConfig : ScriptableObject
    {
        public ElementConfig[] Elements => _elements;
        
        [SerializeField] private ElementConfig[] _elements;
    }
}