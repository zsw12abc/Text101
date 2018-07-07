using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use to create state in Unity
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    //TextArea with min size 10, 14 lines start to scroll
    [TextArea(10, 14)] [SerializeField] private string _storyText;
    [SerializeField] private State[] _nextStates;

    public string GetStateStory()
    {
        return _storyText;
    }

    public State[] GetNextStates()
    {
        return _nextStates;
    }
}