using Game.Scripts.Gameplay.Views;
using UnityEngine;

namespace Game.Scripts.Gameplay
{
    public class SlingMover : IPickableMover
    {
        private SlingMoverView _view;
        
        private readonly Vector3 _startPosition;
        private readonly Quaternion _startRotation;

        public SlingMover(SlingMoverView view)
        {
            _view = view;
            
            _startPosition = _view.transform.position;
            _startRotation = _view.transform.rotation;
        }

        public void Move(Vector3 targetPosition)
        {
            float distance = Vector3.Distance(_startPosition, targetPosition);
            
            if (distance > _view.MaxStretchDistance)
                targetPosition = (targetPosition - _startPosition).normalized * _view.MaxStretchDistance + _startPosition;
            
            _view.transform.position = targetPosition;
            
            _view.transform.rotation = Quaternion.LookRotation(targetPosition - _startPosition) * Quaternion.Euler(180, -90, 0);
        }

        public void Drop()
        {
            _view.transform.position = _startPosition;
            _view.transform.rotation = _startRotation;
        }
    }
}