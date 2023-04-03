using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class BounceAngleController : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.TryGetComponent<Ball>(out var ball))
            {
                var rigitbody = ball.GetComponent<Rigidbody2D>();

                ProcessCollision(transform.position, rigitbody);
                
            }
        }

        private void ProcessCollision(Vector3 centerPos, Rigidbody2D rigitbody)
        {
            var ballPos = rigitbody.position;
            
        }
    }
}