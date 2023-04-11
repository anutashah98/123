using System;
using System.Linq;
using DefaultNamespace.UI;
using UnityEngine;

namespace DefaultNamespace
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private ElementsConfig _elements;
        [SerializeField] private ElementName _firstElement = ElementName.Fire;
        
        [SerializeField] private float _constantSpeed = 10f;

        private ElementConfig _currentElement;


        private void Awake()
        {
            ChangeElement(_firstElement);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            // var otherBlock = collision.transform.GetComponent<Block>();
            // if (otherBlock == null) return;

            if (collision.transform.TryGetComponent<Block>(out Block otherBlock))
            {
                if (_currentElement.Name == otherBlock.Element || otherBlock.Element == ElementName.None)
                {
                    BlockManager.Instance.DamageBlock(otherBlock);
                }
                else
                {
                    ChangeElement(otherBlock.Element);
                }
            }   
            
            
            if (collision.transform.TryGetComponent<KillPlane>(out KillPlane _))
            {
                BallsManager.Instance.DestroyBall(this);
            }
            
            
            
        }

        private void ChangeElement(ElementName otherElement)
        {
            var allElements = _elements.Elements;

            ElementConfig newElementConfig = null;

            // foreach (var e in allElements)
            // {
            //     if (e.Name == otherElement)
            //     {
            //         newElementConfig = e;
            //         break;
            //     }
            // }

            newElementConfig = allElements.FirstOrDefault(e => e.Name == otherElement);
            
            if (newElementConfig == null) return;

            var renderer = GetComponent<Renderer>();
            renderer.sharedMaterial = newElementConfig.Material;

            gameObject.layer = LayerMask.NameToLayer(newElementConfig.LayerName);

            _currentElement = newElementConfig;
        }
    }
}