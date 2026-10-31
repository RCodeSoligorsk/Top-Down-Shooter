using Game.Scripts.Gameplay.Views;

namespace Game.Scripts.Gameplay
{
    public class PlayerCharacterInteractor
    {
        private IInputService _inputService;
        private CharacterView _view;

        public PlayerCharacterInteractor(IInputService inputService, CharacterView view)
        {
            _inputService = inputService;
            _view = view;
        }
        
        
    }
}