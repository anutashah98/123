using System;
using UnityEngine;

namespace DefaultNamespace
{
    public abstract class IAimInputProviderBase : MonoBehaviour
    {
        public abstract event Action OnLaunch;
        public abstract Vector2 GetAimTarget();
        
    }
}