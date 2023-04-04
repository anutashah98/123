using UnityEngine;

namespace DefaultNamespace
{
    public class HorizontalInputController : HorizontalInputProviderBase
    {
        private float _horizontalInput;

        private void Update()
        {
            _horizontalInput = Input.GetAxis("Horizontal");
            
        }

        public override float GetCurrentInput()
        {
            return _horizontalInput;
        }
    }
}