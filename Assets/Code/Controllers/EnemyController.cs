using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController :IClean,IExecute,IInitialization 
{
    private HeroGunModel gunModel;
    private GunView gunView;
    private ShieldView shieldView;
    private ShieldModel shieldModel;
    private EnemyModel enemyModel;
    private GameObject attentionPoint;
   public EnemyController(GunView _gunView,ShieldView _shieldView,GameObject _attentonPoint,GameObject point1,GameObject point2 )
    {
        gunView = _gunView;
        shieldView = _shieldView;
        attentionPoint = _attentonPoint;
        gunModel = new HeroGunModel(gunView,attentionPoint.transform);
        shieldModel = new ShieldModel(shieldView,gunView);
        enemyModel = new EnemyModel(point1, point2, attentionPoint);
        shieldView.Hit += shieldModel.Damage;

    }

    public void Clean()
    {
        shieldView.Hit -= shieldModel.Damage;
    }

    public void Execute()
    {
        gunModel.Execute();
        enemyModel.Execute();
    }

    IEnumerator ShootTimer()
    {
        yield return new WaitForSeconds(Random.Range(2,6));
        gunModel.Shoot();
        gunView.StartCoroutine(ShootTimer());
        
    }
    IEnumerator ShieldTimer()
    {
        yield return new WaitForSeconds(Random.Range(16,30));
        shieldModel.activate();
        gunView.StartCoroutine(ShieldTimer());
        
    }

    public void Init()
    {
        gunView.StartCoroutine(ShieldTimer());
        gunView.StartCoroutine(ShootTimer());
    }
}
