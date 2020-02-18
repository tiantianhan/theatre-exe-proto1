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
    [SerializeField]
    Text sadText = null;
    [SerializeField]
    Text joyText = null;
    [SerializeField]
    Text fearText = null;
    [SerializeField]
    Text envyText = null;

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
        angerText.rectTransform.localScale=new Vector3(state.anger+1,state.anger+1,1);

        sadText.text = "Sad " + Mathf.Round(state.sadness * 100) + "%";
        sadText.rectTransform.localScale = new Vector3(state.sadness + 1, state.sadness + 1, 1);

        joyText.text = "joy " + Mathf.Round(state.joy * 100) + "%";
        joyText.rectTransform.localScale = new Vector3(state.joy + 1, state.joy + 1, 1);

        fearText.text = "Fear " + Mathf.Round(state.fear * 100) + "%";
        fearText.rectTransform.localScale = new Vector3(state.fear + 1, state.fear + 1, 1);

        envyText.text = "Envy " + Mathf.Round(state.envy * 100) + "%";
        envyText.rectTransform.localScale = new Vector3(state.envy+ 1, state.envy + 1, 1);
    }
}
