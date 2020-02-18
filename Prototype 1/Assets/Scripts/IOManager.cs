using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Extracts emotion state input from hardware.
/// Access: IOManager.Singleton
/// </summary>
public class IOManager : MonoBehaviour
{
    public static IOManager Singleton = null;

    void Awake(){
        Debug.Assert(Singleton == null, "IOManager Singleton not null on Awake.");
        Singleton = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        EmotionState change = new EmotionState();
        bool didChange = false;
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            change.anger += 0.1f;
            didChange = true;
        }

        if(Input.GetKeyDown(KeyCode.DownArrow)){
            change.anger -= 0.1f;
            didChange = true;
        }

        if(didChange){
            StateManager.Singleton.UpdateEmotions(change);
        }
    }
}