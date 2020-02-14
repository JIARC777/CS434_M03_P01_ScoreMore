using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public delegate void MilestoneReached();
    public static event MilestoneReached OnMilestone;
    // bool to ensure function is not called multiple times
    bool eventHasBeenCalled = false;
    // Grab the reference to the player's Position
    public Transform playerDist;
    // Grab the text 
    public Text scoreText;
    public int milestone = 100;
    // Update is called once per frame
    void Update()
    {
        // copy distance to text
        scoreText.text = playerDist.position.z.ToString("0");
        // Search for multiples of the milestone to run commands
        if ((int)playerDist.position.z % milestone == 0 && ((int)playerDist.position.z >= milestone) && (OnMilestone != null) && !eventHasBeenCalled)
        {
            Debug.Log("Call milestone");
            OnMilestone();
            eventHasBeenCalled = true;
        }
        else if ((int)playerDist.position.z % milestone > 0)
            eventHasBeenCalled = false;
    }

}
