
using UnityEngine;

public class UiController : IClean
{
    private UiData _uiData;
    private CanvasView _uiCanvas;
    private ButtonView _settingsButton;
    private ButtonView _shieldButton;
    private HealthBarView _enemyHealthBar;
    private HealthBarView _heroHealthBar;
    private SettingsView _settingsView; 

    public CanvasView UiCanvas { get => _uiCanvas; set => _uiCanvas = value; }
    public ButtonView SettingsButton { get => _settingsButton; set => _settingsButton = value; }
    public ButtonView ShieldButton { get => _shieldButton; set => _shieldButton = value; }
    public HealthBarView EnemyHealthBar { get => _enemyHealthBar; set => _enemyHealthBar = value; }
    public HealthBarView HeroHealthBar { get => _heroHealthBar; set => _heroHealthBar = value; }
    public SettingsView SettingsView { get => _settingsView; set => _settingsView = value; }

    public UiController(UiData data)
    {
        _uiData = data;
    }
    public void Clean()
    {
        SettingsButton.Clean();
        ShieldButton.Clean();
        SettingsView.Quit.Clean ();
        SettingsView.Restart.Clean();
    }

    public void init()
    {
        UiCanvas = GameObject.Instantiate<CanvasView>(_uiData.UiCanvas);
        SettingsButton = GameObject.Instantiate<ButtonView>(_uiData.SettingsButton,_uiCanvas.SettingsButtonSpot.transform );
        ShieldButton = GameObject.Instantiate<ButtonView>(_uiData.ShieldButton, _uiCanvas.ShieldButtonSpot.transform );
        EnemyHealthBar = GameObject.Instantiate<HealthBarView>(_uiData.EnemyHealthBar, _uiCanvas.EnemyHealthBarSpot.transform);
        HeroHealthBar = GameObject.Instantiate<HealthBarView>(_uiData.HeroHealthBar, _uiCanvas.PlayerHealthBarSpot.transform);
        SettingsView = GameObject.Instantiate<SettingsView>(_uiData.SettingsView, _uiCanvas.transform );

        ShieldButton.init();
        SettingsButton.init();
        SettingsView.Quit.init();
        SettingsView.Restart.init();
    }
}
