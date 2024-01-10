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
   // public string [] boy_animations = { "boy_Hello", "boy_Age", "boy_Name", "boy_Play", "lets_play", "ready", "scissors_onemore", "paper_onemore", "rock", "you_win" };

    //public string[] Real_boy_animations = { "1_hello", "2_tell_me_about_yourself", "3_dog_task", "4_dog_like", "5_apple_task",
    //"6_apple_count", "8_good_job", "9_chicken", "10_amazing", "11_good_bye"};

    public string[] Real_boy_animations = { "hello", "about_yourself", "dog_task", "dog_like", "apple_task",
    "apple_count", "good_job", "chicken", "amazing", "good_bye"};

    public GameObject blackScreen;
    public int index = 0;

    public int real_boy_index = 0;
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
            real_boy_index++;
            if (real_boy_index >= Real_boy_animations.Length)
                real_boy_index = 0;
        }
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            // Application.Quit();
            boy.SetTrigger(Real_boy_animations[real_boy_index]);
        }

       // if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick))
       // {
          //  boy.SetTrigger("i_win");
          // boy.Play("i_win");
            // Application.Quit();
           
       // }
    }
}
