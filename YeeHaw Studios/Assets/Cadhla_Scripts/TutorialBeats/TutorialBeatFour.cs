﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBeatFour : MonoBehaviour
{
    Tutorial_Text displayBeat;

    public Player player;

    private bool tutTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (tutTrigger == false)
            {
                GameObject obj = GameObject.FindGameObjectWithTag("TutorialDisplay");
                displayBeat = obj.GetComponent<Tutorial_Text>();

                displayBeat.TutorialBeatFour();

                tutTrigger = true;

                StartCoroutine(EndTutorial());
            }
        }
    }

    IEnumerator EndTutorial()
    {
        yield return new WaitForSecondsRealtime(6);
        Destroy(gameObject);
    }
}
