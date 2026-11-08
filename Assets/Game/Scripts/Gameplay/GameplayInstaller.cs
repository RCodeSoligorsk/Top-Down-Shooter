using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Gameplay;
using Game.Scripts.Gameplay.Views;
using UnityEngine;
using Zenject;

public class GameplayInstaller : MonoInstaller<GameplayInstaller>
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private CharacterView _characterPrefab;
    [SerializeField] private BirdSpawnerView _birdSpawnerView;

    public override void InstallBindings()
    {
        BindCharacterView();
        BindCharacterMover();
        
        BindPlayerCharacterInteractor();

        BindBirdSpawnerView();
        BindBirdSpawner();
    }

    private void BindBirdSpawner()
    {
        Container
            .BindInterfacesAndSelfTo<BirdSpawner>()
            .AsSingle()
            .NonLazy();
    }

    private void BindBirdSpawnerView()
    {
        Container
            .Bind<BirdSpawnerView>()
            .FromInstance(_birdSpawnerView)
            .AsSingle()
            .NonLazy();
    }

    private void BindPlayerCharacterInteractor()
    {
        Container
            .BindInterfacesAndSelfTo<PlayerCharacterInteractor>()
            .AsSingle()
            .NonLazy();
    }

    private void BindCharacterView()
    {
        Container
            .Bind<CharacterView>()
            .FromComponentInNewPrefab(_characterPrefab)
            .UnderTransform(_spawnPoint)
            .AsSingle()
            .NonLazy();
    }

    private void BindCharacterMover()
    {
        Container
            .BindInterfacesAndSelfTo<CharacterMover>()
            .AsSingle()
            .NonLazy();
    }
}
