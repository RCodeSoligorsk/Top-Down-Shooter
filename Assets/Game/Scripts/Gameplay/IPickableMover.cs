using UnityEngine;

namespace Game.Scripts.Gameplay
{
    public interface IPickableMover
    {
        void Move(Vector3 position);
		void Drop();
    }
}