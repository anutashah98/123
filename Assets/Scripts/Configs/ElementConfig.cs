using System;
using UnityEngine;

namespace DefaultNamespace.UI
{
    [Serializable]
    public class ElementConfig
    {
        public ElementName Name;
        public Material Material;
        public string LayerName = "Default";
    }
}