using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControls : MonoBehaviour
{
    public void Save()
    { GameManager.manager.Save(); }

    public void Load()
    { GameManager.manager.Load(); }

    public void NewGame()
    { GameManager.manager.NewGame(); }

    public void ReturnToMenu()
    { GameManager.manager.ReturnToMainMenu(); }

    public void Quit()
    { GameManager.manager.Quit(); }

    public void ChangeSceneNext()
    { GameManager.manager.ChangeSceneNext(); }

    public void ChangeScenePrevious()
    { GameManager.manager.ChangeScenePrevious(); }
}
