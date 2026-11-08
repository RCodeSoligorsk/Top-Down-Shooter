using System;
using UnityEngine;

namespace Game.Scripts.Gameplay.Views
{
    public class SlingMoverView : MonoBehaviour, IPickableMoverView
    {
        [field: SerializeField] public float MaxStretchDistance { get; private set; }
        
        public IPickableMover PickableMover { get; private set; }

        private void Awake()
        {
            PickableMover = new SlingMover(this);
        }
    }
}