using UnityEngine;

namespace Game.Scripts.Gameplay
{
    [CreateAssetMenu(fileName = "New Bird Data", menuName = "Game/Bird Data", order = 0)]
    public class BirdData : ScriptableObject
    {
        [field:SerializeField] public float Speed { get; private set; }
        [field:SerializeField] public float Mass { get; private set; }
        [field:SerializeField] public GameObject Model { get; private set; }
        [field:SerializeField] public BirdType Type { get; private set; }
    }
}