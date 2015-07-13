using Core;
using UnityEngine;
using DG.Tweening;

public class LevelController
{
    private LevelInput levelInput;

    private ILevel level;

    public LevelController()
    {
        InitListener();
        EaseToNextLevel();
    }

    private void InitListener()
    {
        GameObject inputgo = new GameObject("InputListener");
        levelInput = inputgo.AddComponent<LevelInput>();
        levelInput.AddEventListener(LevelInputEvent.TouchStart, TouchStartHandler);
        levelInput.AddEventListener(LevelInputEvent.TouchEnd, TouchEndHandler);
        levelInput.AddEventListener(LevelInputEvent.TouchClick, TouchClickHandler);
        levelInput.AddEventListener(LevelInputEvent.Key, KeyHandler);
    }

    private void EaseToNextLevel()
    {

    }

    private void NextLevel()
    {
        
    }

    private void TouchStartHandler(IEvent e)
    {
        
    }

    private void TouchEndHandler(IEvent e)
    {
        
    }

    private void TouchClickHandler(IEvent e)
    {
        
    }

    private void KeyHandler(IEvent e)
    {
        
    }
}
