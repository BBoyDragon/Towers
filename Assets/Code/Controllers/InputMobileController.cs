using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class InputMobileController :IExecute,IClean
{
    private Vector2 touchPosition;
    private event Action onTouchUp;
    private HeroGunModel gunModel;
    private GameObject point;
    public InputMobileController(HeroGunModel _gunModel,GameObject _point )
    {
        gunModel = _gunModel;
        onTouchUp += gunModel.Shoot;
        point = _point;
    }

    public void Execute()
    {
        if (Time.timeScale != 0)
        {
            if (Input.touchCount > 0)
            {
                point.transform.position = Input.GetTouch(0).position;
                if (Input.GetTouch(0).phase == TouchPhase.Canceled || Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    onTouchUp.Invoke();
                }
            }
        }

    }

    public void Clean()
    {
        onTouchUp -= gunModel.Shoot;
    }
}
