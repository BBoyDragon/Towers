using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroGunModel 
{
    private Transform target;
    private GunView view;
    public HeroGunModel(GunView _view,Transform _target)
    {
        target = _target;
        view = _view;
    }
    public void Execute()
    {
        LookAt2D(target.position);
    }
    public void Shoot()
    {
       Rigidbody2D go= GameObject.Instantiate<Rigidbody2D >(Resources.Load<Rigidbody2D>("bullet"), view.ActivePart.transform.position, Quaternion.identity);
        go.AddForce((target.position - view.ActivePart.transform.position).normalized*1000);
        GameObject.Destroy(go, 10f);
    }
    private void LookAt2D(Vector3 lookTarget)
    {
        Vector3 yDirection = (lookTarget - view.ActivePart.transform.position).normalized;
        Vector3 xDirection = Quaternion.Euler(0, 0, 90) * yDirection;
        Vector3 zDirection = Vector3.forward;
        view.ActivePart.transform.rotation = Quaternion.LookRotation(zDirection, yDirection);
    }
}
