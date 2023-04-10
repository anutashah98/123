using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class LaserPointerView : MonoBehaviour
    {
        [SerializeField]private AimInputProviderBase _aimInputProvider;
        [SerializeField]private BallLauncher _ballLauncher;

        private void Awake()
        {
            _ballLauncher.OnLaunched += Hide;
        }

        private void Hide()
        {
            Destroy(gameObject);
        }

        private void OnDestroy()
        {
            _ballLauncher.OnLaunched -= Hide;
        }

        private void Update()
        {
            Vector3 targetPoint = _aimInputProvider.GetAimTarget();

            var direction = targetPoint - transform.position;
            transform.up = direction;
        }
    }
}