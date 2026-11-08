using Game.Scripts.Gameplay.Views;

namespace Game.Scripts.Gameplay
{
    public class BirdSpawner
    {
        private BirdSpawnerView _view;
        private BirdFactory _factory;

        public BirdSpawner(BirdSpawnerView view)
        {
            _view = view;
            
            _factory = new BirdFactory();
            
            Spawn();
        }

        private void Spawn()
        {
            int birdIndex = 0;
            
            foreach (BirdData birdData in _view.Birds)
            {
                BirdView birdView = _factory.Create(birdData);

                birdView.transform.position = _view.transform.position 
                                              + _view.Direction * _view.DistanceBetween * birdIndex;

                birdIndex++;
            }
        }
    }
}