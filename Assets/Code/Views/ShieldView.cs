using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShieldView : MonoBehaviour
{
    public event Action Hit;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Debug.Log("hit");
            Hit.Invoke();
            GameObject.Destroy(collision.gameObject);
        }
    }
}
