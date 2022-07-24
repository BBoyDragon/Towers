using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
public class Data :ScriptableObject
{
    [SerializeField]
    private MapView map;
    [SerializeField]
    private GunView gunView;
    [SerializeField]
    private ShieldView shieldView;


    public MapView Map { get => map; set => map = value; }
    public GunView GunView { get => gunView; set => gunView = value; }
    public ShieldView ShieldView { get => shieldView; set => shieldView = value; }
}
