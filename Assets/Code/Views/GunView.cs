using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunView : MonoBehaviour
{
    [SerializeField]
    private GameObject _activePart;

    public GameObject ActivePart { get => _activePart; set => _activePart = value; }
}
