using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class LaserPointerView : MonoBehaviour
    {
        [SerializeField]private AimInputProviderBase _aimInputProvider;
        
        private void Update()
        {
            Vector3 targetPoint = _aimInputProvider.GetAimTarget();
            
            transform.LookAt(targetPoint);
            
            // Vector3 startPoint = transform.position;
            //
            // var direction = targetPoint - startPoint;
            //
            // var rotation = Quaternion.LookRotation(direction);
            // rotation.z = rotation.x;
            // rotation.y = 0f;
            // rotation.x = 0f;
            //
            // transform.rotation = rotation;
        }
    }
}