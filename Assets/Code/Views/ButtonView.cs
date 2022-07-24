using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    public event Action OnClick;
    public void init()
    {
        _button.onClick.AddListener(() => OnClick?.Invoke());
    }
    public void Clean()
    {
        _button.onClick.RemoveAllListeners();
    }
}
