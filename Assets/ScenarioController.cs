using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioController : MonoBehaviour
{
    [Tooltip("The button used to begin aiming for a teleport.")]
    public OVRInput.RawButton AimButton;
    public Animator farmer;
    public Animator boy;

    public string [] animations = { "Hello", "Here", "Hand", "GJ"};
    public string [] boy_animations = { "boy_Hello", "boy_Age", "boy_Name", "boy_Play", "lets_play", "ready", "scissors_onemore", "paper_onemore", "rock", "you_win" };
    public GameObject blackScreen;
    public int index = 0;

    public int boy_index = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started...");
        //DebugUIBuilder.instance.AddLabel("Scenario Controller");
    }

    // Update is called once per frame
    void Update()
    {
       
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("Pressed...");
            //DebugUIBuilder.instance.AddLabel("Pressed a button " + animations[index]);
            index++;
            if (index >= animations.Length)
                index = 0;
            //farmer.SetTrigger(animations[index++]);
        }
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            Debug.Log("Pressed...");
            //DebugUIBuilder.instance.AddLabel("Pressed a button " + animations[index]);
            farmer.SetTrigger(animations[index]);            
        }

        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            // UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            Debug.Log("Pressed...");
            //DebugUIBuilder.instance.AddLabel("Pressed a button " + animations[index]);
            boy_index++;
            if (boy_index >= boy_animations.Length)
                boy_index = 0;
        }
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            // Application.Quit();
            boy.SetTrigger(boy_animations[boy_index]);
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick))
        {
            boy.SetTrigger("i_win");
          // boy.Play("i_win");
            // Application.Quit();
           
        }
    }
}
