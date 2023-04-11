using System;
using System.Collections;
using UnityEngine;
using UnityEngine.WSA;
using Application = UnityEngine.WSA.Application;

namespace DefaultNamespace
{
    public class BallLauncher : MonoBehaviour
    {
        public event Action OnLaunched; 

        [SerializeField] private int _ballsPerLaunch = 20;
        [SerializeField] private float _delayBetweenLaunches = 0.2f;
        
        [SerializeField] private float _launchSpeed = 1f;
        [SerializeField] private Rigidbody2D _ballPrefab;
        [SerializeField] private AimInputProviderBase _inputProvider;

        private void Start()
        {
            _inputProvider.OnLaunch += Launch;
        }

        private void Launch()
        {
            _inputProvider.OnLaunch -= Launch;

            StartCoroutine(LaunchAllBall());
            
            OnLaunched?.Invoke();
        }

        private IEnumerator LaunchAllBall()
        {
            for (int i = 0; i < _ballsPerLaunch; i++)
            {
                var ball = Instantiate(_ballPrefab);
                ball.position = transform.position;
            
                var shootDirection = _inputProvider.GetAimTarget() - ball.position;
            
                shootDirection.Normalize();
                shootDirection *= _launchSpeed;

                ball.transform.parent = null;
                ball.AddForce(shootDirection, ForceMode2D.Impulse);

                yield return new WaitForSeconds(_delayBetweenLaunches);
            }
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