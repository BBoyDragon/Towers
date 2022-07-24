using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButtonController :IClean
{
    private SettingsView view;
    private ButtonView settingsButton;
    public SettingsButtonController(SettingsView _view,ButtonView button )
    {
        view = _view;
        settingsButton = button;
        view.Restart.OnClick += Restart;
        view.Quit.OnClick += Quit;
        settingsButton.OnClick += activate;
    }
    private void activate()
    {
        
        if (Time.timeScale == 1 && view.gameObject.activeSelf==false)
        {
            Time.timeScale = 0;
            view.gameObject.SetActive(true);

        }else if (Time.timeScale == 0 && view.gameObject.activeSelf == true )
        {
            Time.timeScale = 1;
            view.gameObject.SetActive(false );

        }
    }

    public void Clean()
    {
        view.Restart.OnClick -= Restart;
        view.Quit.OnClick -= Quit;
        settingsButton.OnClick -= activate;
    }

    private void Quit()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
    private void Restart()
    {
        
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
