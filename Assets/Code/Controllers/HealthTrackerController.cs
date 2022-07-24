using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthTrackerController:IClean
{
    private HealthBarView enemyBar;
    private HealthBarView heroBar;

    private GunView heroView;
    private GunView enemyView;

    private float enemyHP=100;
    private float heroHP=100;
   public HealthTrackerController(HealthBarView enemy,HealthBarView hero,GunView enemyGun,GunView heroGun)
    {
        enemyBar = enemy;
        heroBar = hero;
        heroView = heroGun;
        enemyView = enemyGun;

        heroView.HeroHit += HitHero;
        enemyView.HeroHit += HitEnemy;

    }

    public void Clean()
    {
        heroView.HeroHit -= HitHero;
        enemyView.HeroHit -= HitEnemy;

    }

    private void HitEnemy()
    {
        enemyHP -= 20;
        enemyBar.Bar.fillAmount = enemyHP / 100;
        if(enemyHP<=0)
        SceneManager.LoadScene(0);
        
    }
    private void HitHero()
    {
        heroHP -= 20;
        heroBar.Bar.fillAmount = heroHP / 100;
        if(enemyHP<=0)
        SceneManager.LoadScene(0);
    }


}
