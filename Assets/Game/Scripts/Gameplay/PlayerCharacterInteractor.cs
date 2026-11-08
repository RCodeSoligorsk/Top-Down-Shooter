using Game.Scripts.Gameplay.Views;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Gameplay
{
    public class PlayerCharacterInteractor : ITickable
    {
        private IInputService _inputService;
        private CharacterView _view;

        private IPickableMover _pickableMover;

        public PlayerCharacterInteractor(IInputService inputService, CharacterView view)
        {
            _inputService = inputService;
            _view = view;

            _inputService.UseStarted += OnUseStart;
            _inputService.UseStopped += OnUseStop;
        }

        private void OnUseStart()
        {
            Ray ray = new Ray(_view.Head.transform.position, _view.Head.transform.forward);

            if (Physics.Raycast(ray, out RaycastHit hit, _view.ReachDistance, _view.InteractableLayer) == false)
                return;

            if (hit.collider.TryGetComponent(out IPickableMoverView pickable) == false)
                return;

            _pickableMover = pickable.PickableMover;
        }

        private void OnUseStop()
        {
            if (_pickableMover == null) 
                return;
            
            _pickableMover.Drop();
            _pickableMover = null;
        }

        public void Tick()
        {
            if (_pickableMover == null) 
                return;
            
            _pickableMover.Move(_view.Hands.position);
        }
    }
}