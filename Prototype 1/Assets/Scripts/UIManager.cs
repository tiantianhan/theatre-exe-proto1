using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Updates UI based on emotional state
/// Access: UIManager.Singleton
/// </summary>
public class UIManager : MonoBehaviour
{
    /// <summary>
    /// Singleton used to access UI manager
    /// </summary>
    public static UIManager Singleton = null;

    [SerializeField] 
    Text angerText = null;

    void Awake(){
        Debug.Assert(Singleton == null, "UIManager Singleton not null on Awake.");
        Singleton = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateUI(EmotionState state){
        angerText.text = "Anger " + Mathf.Round(state.anger * 100) + "%";
    }
}
