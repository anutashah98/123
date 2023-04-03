using UnityEngine;

namespace DefaultNamespace
{
    public class HorizontalInputController : IHorizontalInputProviderBase
    {
        private float _horizontalInput;

        public override void OnUpdate()
        {
            _horizontalInput = Input.GetAxis("Horizontal");
            
        }

        public override float GetCurrentInput()
        {
            return _horizontalInput;
        }
    }
}