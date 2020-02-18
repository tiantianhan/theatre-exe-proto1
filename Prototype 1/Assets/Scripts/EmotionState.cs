using UnityEngine;

/// <summary>
/// Information about the emotion state, where 0 is least emotion, 1 is most emotion.
/// Can be used as input for functions that update or store emotion states
/// </summary>

public class EmotionState
{
    public float anger = 0.0f;
    public float sadness = 0.0f;
    public float joy = 0.0f;
    public float fear = 0.0f;
    public float envy = 0.0f;

    public void PrintState(){
        Debug.Log("anger " + anger);
    }
}
