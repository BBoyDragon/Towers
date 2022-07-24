using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField]
    private Data LevelData;
    private GameInit _gameInit;
    private GameController _controllers;

    private void Awake()
    {
        _controllers = new GameController(); ;
        _gameInit = new GameInit(LevelData,_controllers);


        _controllers.Awake();

    }

    private void Start()
    {
        _controllers.Init();
    }

    private void Update()
    {
        _controllers.Execute();
    }

    private void FixedUpdate()
    {
        _controllers.FixedExecute();
    }

    private void LateUpdate()
    {
        _controllers.LateExecute();
    }

    private void OnDestroy()
    {
        _controllers.Clean();
    }
}

