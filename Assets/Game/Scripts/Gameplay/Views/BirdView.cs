using System;
using UnityEngine;

namespace Game.Scripts.Gameplay.Views
{
    [RequireComponent(typeof(Rigidbody), typeof(SphereCollider))]
    public class BirdView : MonoBehaviour
    {
        public Rigidbody Rigidbody {get; private set;}
        public SphereCollider SphereCollider {get; private set;}

        private void Awake()
        {
            Rigidbody = GetComponent<Rigidbody>();
            SphereCollider = GetComponent<SphereCollider>();
        }
    }
}