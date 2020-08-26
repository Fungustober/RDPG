using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verb : MonoBehaviour
{
    public string[] verbList;
    public string vrb = "Running|+Digging|+Beating|Rising|+Biting|Eating|Speaking|Writing|Speaking|Cooking|+Fixing|Fleeing|Sitting|+Stopping|Listening|Crying|Stinking|Roaming|Bluffing|Barfing|Rotting|+Repairing|Lying|Bidding|+Breaking|+Dragging|+Drawing|Diving|Falling|+Fighting|Flying|Freezing|Hiding|Rising|Seeing|Shaking|Shining|Shrinking|Singing|Sinking|+Slaying|Swearing|+Stealing|+Throwing|Weaving|Arguing|Celebrating|+Containing|Crawling|+Carrying|Sliding|Snoring|+Threatening|Waving|Existing|Playing|Sleeping|Waiting|Complaining|+Pursuing|+Paying|Cutting|Building|Clapping|+Calling|+Avoiding|+Battling|Tiptoeing|+Watching|+Tolerating";
    private void Start()
    {
        verbList = vrb.Split('|');
    }
}
