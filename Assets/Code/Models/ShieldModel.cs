using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldModel 
{
    private ShieldView _view;
    private int _shieldHP;
    private bool _isActive=false;
    private bool _isCoolDowned=true ;
    private MonoBehaviour _couratineStarter;
    public ShieldModel(ShieldView view,MonoBehaviour couratineStarter)
    {
      _view=view;
        _couratineStarter = couratineStarter;
    }
    public void activate()
    {
        if (_isActive == false&& _isCoolDowned)
        {
            _shieldHP = 3;
            _view.gameObject.SetActive(true);
            _isActive = true;
        } 
    }
    public void Damage()
    {

        _shieldHP -= 1;
        if (_shieldHP <= 0)
        {
            _view.gameObject.SetActive(false);
            _isActive = false;
            _isCoolDowned = false;
            _couratineStarter.StartCoroutine(StartTimer());
        }
    }
    IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(15f);
        _isCoolDowned = true;
    }
}
