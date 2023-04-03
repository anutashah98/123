using UnityEngine;

namespace DefaultNamespace
{
    public abstract class IHorizontalInputProviderBase : MonoBehaviour
    {
        public abstract void OnUpdate();
        public abstract float GetCurrentInput();
    }
}