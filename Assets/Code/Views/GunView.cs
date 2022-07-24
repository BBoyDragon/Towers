using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GunView : MonoBehaviour
{
    [SerializeField]
    private GameObject _activePart;
    public event Action HeroHit;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            HeroHit.Invoke();
            GameObject.Destroy(collision.gameObject);
        }
    }

    public GameObject ActivePart { get => _activePart; set => _activePart = value; }
}
