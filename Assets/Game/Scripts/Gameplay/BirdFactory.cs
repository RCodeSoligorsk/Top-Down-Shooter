using Game.Scripts.Gameplay.Views;
using UnityEngine;

namespace Game.Scripts.Gameplay
{
    public class BirdFactory
    {
        public BirdView Create(BirdData birdData)
        {
            GameObject bird = new GameObject(birdData.Type.ToString());
            BirdView birdView = bird.AddComponent<BirdView>();
            birdView.SphereCollider.radius = 0.24f;
            birdView.Rigidbody.mass = birdData.Mass;
            GameObject.Instantiate(birdData.Model, bird.transform);
            
            return birdView;
        }
    }
}