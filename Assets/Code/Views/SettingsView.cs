using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsView : MonoBehaviour
{
    [SerializeField]
    private ButtonView _restart;
    [SerializeField]
    private ButtonView _quit;

    public ButtonView Restart { get => _restart; set => _restart = value; }
    public ButtonView Quit { get => _quit; set => _quit = value; }
}
