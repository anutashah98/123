using System;
using UnityEngine;
using UnityEngine.WSA;
using Application = UnityEngine.WSA.Application;

namespace DefaultNamespace
{
    public class BallLauncher : MonoBehaviour
    {
        [SerializeField] private float _launchSpeed = 1f;
        [SerializeField] private Rigidbody2D _ball;
        [SerializeField] private IAimInputProviderBase _inputProvider;

        private void Start()
        {
            _inputProvider.OnLaunch += Launch;

            _ball.transform.parent = transform;
        }

        private void Launch()
        {
            _inputProvider.OnLaunch -= Launch;

            var shootDirection = _inputProvider.GetAimTarget() - _ball.position;
            
            shootDirection.Normalize();
            shootDirection *= _launchSpeed;

            _ball.transform.parent = null;
            _ball.AddForce(shootDirection, ForceMode2D.Impulse);
        }
        
        

        // private void OnDrawGizmos()
        // { 
        //     if (!UnityEngine.Device.Application.isPlaying) return;
        //     
        //     Gizmos.color = Color.red;
        //
        //     var tragetPos = _inputProvider.GetAimTarget();
        //     var initialPos = transform.position;
        //     
        //     Gizmos.DrawLine(initialPos, tragetPos);
        // }
    }
}