using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioController : MonoBehaviour
{
    [Tooltip("The button used to begin aiming for a teleport.")]
    public OVRInput.RawButton AimButton;
    public Animator farmer;
    public string [] animations = { "Hello", "Here", "Hand", "GJ"};
    public GameObject blackScreen;
    public int index = 0;
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
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            Application.Quit();
        }
    }
}
