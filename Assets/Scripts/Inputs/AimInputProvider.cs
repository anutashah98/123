using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class AimInputProvider : AimInputProviderBase
    {
        
        public override event Action OnLaunch;
        private Vector3 _aimTarget;
        
        public void Update()
        {
            ProcessLaunchInput();
            ProcessAimInput();
        }
        
        public override Vector2 GetAimTarget()
        {
            return _aimTarget;
        }

        private void ProcessAimInput()
        {
            _aimTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        private void ProcessLaunchInput()
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                OnLaunch?.Invoke();
            }
        }

    }
}