using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaSoundController : MonoBehaviour
{
    public AudioClip jump, scoreHighlight;
    private AudioSource audioPlayer;


    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }

    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }
}
