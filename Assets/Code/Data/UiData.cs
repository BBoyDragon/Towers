using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Data/UIData")]
public class UiData : ScriptableObject
{
    [SerializeField]
    private CanvasView _uiCanvas;
    [SerializeField]
    private ButtonView _settingsButton;
    [SerializeField]
    private ButtonView _shieldButton;
    [SerializeField]
    private HealthBarView _enemyHealthBar;
    [SerializeField]
    private HealthBarView _heroHealthBar;
    [SerializeField]
    private SettingsView _settingsView;

    public ButtonView SettingsButton { get => _settingsButton; set => _settingsButton = value; }
    public ButtonView ShieldButton { get => _shieldButton; set => _shieldButton = value; }
    public HealthBarView EnemyHealthBar { get => _enemyHealthBar; set => _enemyHealthBar = value; }
    public HealthBarView HeroHealthBar { get => _heroHealthBar; set => _heroHealthBar = value; }
    public CanvasView UiCanvas { get => _uiCanvas; set => _uiCanvas = value; }
    public SettingsView SettingsView { get => _settingsView; set => _settingsView = value; }
}
