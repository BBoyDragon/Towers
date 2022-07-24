using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapView : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerSpot;
    [SerializeField]
    private GameObject _enemySpot;
    [SerializeField]
    private GameObject _playerShield;
    [SerializeField]
    private GameObject _enemyShield;

    public GameObject PlayerSpot { get => _playerSpot; set => _playerSpot = value; }
    public GameObject EnemySpot { get => _enemySpot; set => _enemySpot = value; }
    public GameObject PlayerShield { get => _playerShield; set => _playerShield = value; }
    public GameObject EnemyShield { get => _enemyShield; set => _enemyShield = value; }
}
