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
    [SerializeField]
    private GameObject _point1;
    [SerializeField]
    private GameObject _point2;
    [SerializeField]
    private GameObject _attentionPoint;

    public GameObject PlayerSpot { get => _playerSpot; set => _playerSpot = value; }
    public GameObject EnemySpot { get => _enemySpot; set => _enemySpot = value; }
    public GameObject PlayerShield { get => _playerShield; set => _playerShield = value; }
    public GameObject EnemyShield { get => _enemyShield; set => _enemyShield = value; }
    public GameObject Point1 { get => _point1; set => _point1 = value; }
    public GameObject Point2 { get => _point2; set => _point2 = value; }
    public GameObject AttentionPoint { get => _attentionPoint; set => _attentionPoint = value; }
}
