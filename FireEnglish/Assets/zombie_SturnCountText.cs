using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_SturnCountText : MonoBehaviour
{
    public TextMesh text;
    public TextMesh MainText;

    private bool MoveGo = false;

    // Update is called once per frame
    private void Update()
    {
        if (tutorialzombieTracking.ZombieSturnCounting <= 8 && !MoveGo)
        {
            text.text = $"{tutorialzombieTracking.ZombieSturnCounting} / 8";
        }
        if (tutorialzombieTracking.ZombieSturnCounting >= 8 && !MoveGo)
        {
            MainText.text = "The door has been opened. Go to the exit ~ !!!";
            MoveGo = true;
        }
    }
}