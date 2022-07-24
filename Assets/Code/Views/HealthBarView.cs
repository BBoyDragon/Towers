using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : MonoBehaviour
{
    [SerializeField]
    private Image _bar;

    public Image Bar { get => _bar; set => _bar = value; }
}
