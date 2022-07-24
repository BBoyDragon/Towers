using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public sealed class GameInit 
{
    private Data _data;
    private UiData _uiData;
    private GameController _controllers;
    private MapView _map;
    private GunView _enemyGun;
    private GunView _playerGun;
    private ShieldView _enemyShield;
    private ShieldView _playerShield;
    private UiController _uiController;
    private ShieldController _shieldController;
    private HeroGunController _heroGunController;
    private EnemyController _enemyController;
    private GameObject _point1;
    private GameObject _point2;
    private GameObject _attentionPoint;
    private HealthTrackerController _healthTrackerController;
    private SettingsButtonController _settingsButtonController; 
   public GameInit(Data data,UiData uiData ,GameController controllers)
    {
        _data = data;
        _uiData = uiData;
        _controllers = controllers;
        initView();

        _uiController = new UiController(_uiData);
        _uiController.init();
        _controllers.Add(_uiController);

        _shieldController = new ShieldController(_playerShield,_uiController.ShieldButton);
        _controllers.Add(_shieldController);

        _heroGunController = new HeroGunController(_playerGun);
        _controllers.Add(_heroGunController);

        _enemyController = new EnemyController(_enemyGun, _enemyShield, _attentionPoint , _point1 , _point2 );
        _controllers.Add(_enemyController);

        _healthTrackerController = new HealthTrackerController(_uiController.EnemyHealthBar, _uiController.HeroHealthBar, _enemyGun, _playerGun);
        _controllers.Add(_healthTrackerController);

        _settingsButtonController = new SettingsButtonController(_uiController.SettingsView, _uiController.SettingsButton);
        _controllers.Add(_settingsButtonController);

        

    }
    private void initView()
    {
        _map = GameObject.Instantiate<MapView>(_data.Map);
        _enemyGun = GameObject.Instantiate<GunView>(_data.GunView,_map.EnemySpot.transform.position, Quaternion.identity);
        _playerGun = GameObject.Instantiate<GunView>(_data.GunView, _map.PlayerSpot.transform.position, Quaternion.identity);
        _playerGun.transform.Rotate(new Vector3(0,180,0));
        _enemyShield = GameObject.Instantiate<ShieldView>(_data.ShieldView, _map.EnemyShield.transform.position,Quaternion.identity);
        _playerShield = GameObject.Instantiate<ShieldView>(_data.ShieldView, _map.PlayerShield.transform.position,Quaternion.identity);
        _point1 = _map.Point1;
        _point2 = _map.Point2;
        _attentionPoint = _map.AttentionPoint;
    }
    
    
}
