using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.Gameplay.Views
{
    public class BirdSpawnerView : MonoBehaviour
    {
        [field:SerializeField] public float DistanceBetween { get; private set; }
        [field:SerializeField] public Vector3 Direction { get; private set; }
        
        [SerializeField] private List<BirdData> _birds = new List<BirdData>();
        
        public IReadOnlyList<BirdData> Birds => _birds;
    }
}