using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasView : MonoBehaviour
{
    [SerializeField]
    private Canvas _canvas;
    [SerializeField]
    private GameObject _settingsButtonSpot;
    [SerializeField]
    private GameObject _shieldButtonSpot;
    [SerializeField]
    private GameObject _playerHealthBarSpot;
    [SerializeField]
    private GameObject _enemyHealthBarSpot;

    public GameObject SettingsButtonSpot { get => _settingsButtonSpot; set => _settingsButtonSpot = value; }
    public GameObject ShieldButtonSpot { get => _shieldButtonSpot; set => _shieldButtonSpot = value; }
    public GameObject PlayerHealthBarSpot { get => _playerHealthBarSpot; set => _playerHealthBarSpot = value; }
    public GameObject EnemyHealthBarSpot { get => _enemyHealthBarSpot; set => _enemyHealthBarSpot = value; }
    public Canvas Canvas { get => _canvas; set => _canvas = value; }
}
