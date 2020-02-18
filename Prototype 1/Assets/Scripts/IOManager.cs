﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Extracts emotion state input from hardware.
/// Access: IOManager.Singleton
/// </summary>
public class IOManager : MonoBehaviour
{
    /// <summary>
    /// Singleton used to access IO manager
    /// </summary>
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
        
        //Anger
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            change.anger += 0.1f;
            didChange = true;
        }

        if(Input.GetKeyDown(KeyCode.DownArrow)){
            change.anger -= 0.1f;
            didChange = true;
        }

        //Sadness
        if (Input.GetKeyDown(KeyCode.S))
        {
            change.sadness += 0.1f;
            didChange = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            change.sadness -= 0.1f;
            didChange = true;
        }

        //Joy
        if (Input.GetKeyDown(KeyCode.J))
        {
            change.joy += 0.1f;
            didChange = true;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            change.joy -= 0.1f;
            didChange = true;
        }

        //Fear
        if (Input.GetKeyDown(KeyCode.F))
        {
            change.fear += 0.1f;
            didChange = true;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            change.fear -= 0.1f;
            didChange = true;
        }

        //Envy
        if (Input.GetKeyDown(KeyCode.E))
        {
            change.envy += 0.1f;
            didChange = true;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            change.envy -= 0.1f;
            didChange = true;
        }


        if (didChange){
            StateManager.Singleton.UpdateEmotions(change);
        }
    }
}