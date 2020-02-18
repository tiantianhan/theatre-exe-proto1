using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Updates emotion state of person on stage based on input.
/// Access: StateManager.Singleton
/// </summary>
public class StateManager : MonoBehaviour
{
    public static StateManager Singleton = null;

    /// <summary>
    /// Current emotion state of person on stage.
    /// </summary>
    private EmotionState currentState = null;
    
    //Trying to add dictionary to be continued  
 // Dictionary<string, float> emoStateValue = new Dictionary<string, float>();

    //public float[] emoStateVlaue; 
    enum DominantEmotion{
        AngerDominant,
        SadDominant,
        JoyDominant,
        FearDominant,
        EnvyDominant,
        NoDominant,
    };

    void Awake(){
        Debug.Assert(Singleton == null, "StateManager Singleton not null on Awake.");
        Singleton = this;

        currentState = new EmotionState();
        currentState.PrintState();
    }

    void Start()
    {
      //  emoStateValue.Add("anger", currentState.anger);
        DominantEmotion DominantEmo;
        DominantEmo = DominantEmotion.NoDominant;

    }

    void Update()
    {
        //TODO: average emotion states? check for when to meltdown?
        
    }

    /// <summary>
    /// Update current emotion state of person on stage based on new inputs.
    /// </summary>
    public void UpdateEmotions(EmotionState emotionChange){
        if(currentState == null) return;

        currentState.anger += emotionChange.anger;
        currentState.sadness += emotionChange.sadness;
        currentState.joy += emotionChange.joy;
        currentState.envy += emotionChange.envy;
        currentState.fear += emotionChange.fear;

        currentState.PrintState();
        UIManager.Singleton.UpdateUI(currentState);
        mapValue();

    }

   public void mapValue()
    {
      
    }

   

    /// <summary>
    /// Get current emotion state of person on stage
    /// </summary>
    public EmotionState GetEmotions(){
        return currentState;
    }

    void TriggerMeltdown(){
        //TODO
    }
}
