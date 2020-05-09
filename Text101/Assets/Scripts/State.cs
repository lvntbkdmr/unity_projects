using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "State", menuName = "State", order = 0)]
public class State : ScriptableObject {
    
    [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
 
    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }

}