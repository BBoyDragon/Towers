using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController:IClean 
{
    private ShieldView view;
    private ButtonView buttonView;
    private ShieldModel model;

    public ShieldController(ShieldView _view, ButtonView _button)
    {
        view = _view;
        buttonView = _button;
        model = new ShieldModel(view,buttonView);
        buttonView.OnClick += model.activate;
        view.Hit += model.Damage;
    }

    public void Clean()
    {
        buttonView.OnClick -= model.activate;
        view.Hit += model.Damage;
    }
}
