using UnityEngine;

namespace Game.Scripts.Gameplay.Views
{
    public class CharacterView : MonoBehaviour
    {
        [field: SerializeField] public CharacterController CharacterController { get; private set; }
        [field: SerializeField] public Transform Head { get; private set; }
        [field: SerializeField] public Transform Hands { get; private set; }
        [field: SerializeField] public float MaxSpeed { get; private set; } = 5.0f;
        [field: SerializeField] public float JumpSpeed { get; private set; } = 5.0f;
        [field: SerializeField] public float Sensitivity { get; private set; } = 3.0f;
        [field: SerializeField] public float MaxVerticalAngle { get; private set; } = 85.0f;
        [field: SerializeField] public float ReachDistance { get; private set; } = 3.0f;
        [field: SerializeField] public LayerMask InteractableLayer { get; private set; }
    }
}