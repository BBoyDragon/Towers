using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameInit 
{
    private Data _data;
    private GameController _controllers;
    private MapView _map;
    private GunView _enemyGun;
    private GunView _playerGun;
    private ShieldView _enemyShield;
    private ShieldView _playerShield;
   public GameInit(Data data,GameController controllers)
    {
        _data = data;
        _controllers = controllers;
        initView();

    }
    private void initView()
    {
        _map = GameObject.Instantiate<MapView>(_data.Map);
        _enemyGun = GameObject.Instantiate<GunView>(_data.GunView,_map.EnemySpot.transform);
        _playerGun = GameObject.Instantiate<GunView>(_data.GunView, _map.PlayerSpot.transform);
        _playerGun.transform.Rotate(new Vector3(0,180,0));
        _enemyShield = GameObject.Instantiate<ShieldView>(_data.ShieldView, _map.EnemyShield.transform);
        _playerShield = GameObject.Instantiate<ShieldView>(_data.ShieldView, _map.PlayerShield.transform);
    }
    
    
}
