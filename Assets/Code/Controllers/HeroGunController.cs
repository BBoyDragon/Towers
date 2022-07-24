using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroGunController:IExecute,IClean
{
    private GunView view;
    private HeroGunModel model;
    private InputMobileController inputController;
    public HeroGunController(GunView _view)
    {
        view = _view;
        GameObject test = GameObject.Instantiate<GameObject>(Resources.Load<GameObject>("test"));
        model = new HeroGunModel(view,test.transform);
        inputController = new InputMobileController(model, test);
    }

    public void Clean()
    {
        inputController.Clean();
    }

    public void Execute()
    {
        model.Execute();
        inputController.Execute();
    }
}
