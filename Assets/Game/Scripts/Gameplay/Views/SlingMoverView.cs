using System;
using UnityEngine;

namespace Game.Scripts.Gameplay.Views
{
    public class SlingMoverView : MonoBehaviour
    {
        [field: SerializeField] public float MaxStretchDistance { get; private set; }
        
        public SlingMover SlingMover { get; private set; }

        private void Awake()
        {
            SlingMover = new SlingMover(this);
        }
    }
}