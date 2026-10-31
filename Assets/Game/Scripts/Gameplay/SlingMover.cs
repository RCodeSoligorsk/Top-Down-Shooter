using Game.Scripts.Gameplay.Views;
using UnityEngine;

namespace Game.Scripts.Gameplay
{
    public class SlingMover
    {
        private SlingMoverView _view;
        
        private readonly Vector3 _startPosition;

        public SlingMover(SlingMoverView view)
        {
            _view = view;
            
            _startPosition = _view.transform.position;
        }

        public void Move(Vector3 targetPosition)
        {
            float distance = Vector3.Distance(_startPosition, targetPosition);
            
            if (distance > _view.MaxStretchDistance)
                targetPosition = (targetPosition - _startPosition).normalized * _view.MaxStretchDistance + _startPosition;
            
            _view.transform.position = targetPosition;
        }

        public void Reset()
        {
            _view.transform.position = _startPosition;
        }
    }
}