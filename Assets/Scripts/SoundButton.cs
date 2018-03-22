using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour {
    [SerializeField]
    private Text soundText;
    [SerializeField]
    private Image buttonImage;
    [SerializeField]
    private Color playingColor;
    [SerializeField]
    private Color stopedColor;
    [SerializeField, Space(10)]
    private Sound sound;

    private bool isDragging = false;
    private IEnumerator checkSoundStop;

    public Text SoundText
    {
        get
        {
            return soundText;
        }

        set
        {
            soundText = value;
        }
    }

    public Sound Sound
    {
        get
        {
            return sound;
        }

        set
        {
            sound = value;
            SoundText.text = sound.name;
        }
    }


    private void Awake()
    {
        checkSoundStop = CheckSoundStop();    
    }

    private void OnMouseUp()
    {
        if (!sound.Source.isPlaying && buttonImage.raycastTarget)
        {
            AudioManager.instance.PlaySound(sound);
            buttonImage.color = playingColor;

            if (!sound.loop)
            {
                StartCoroutine(checkSoundStop);
            }           
        }
        else if (sound.Source.isPlaying && buttonImage.raycastTarget)
        {
            AudioManager.instance.StopSound(sound);
            buttonImage.color = stopedColor;

            StopCoroutine(checkSoundStop);
        }

        isDragging = false;
    }

    IEnumerator CheckSoundStop()
    {
        yield return new WaitForSeconds(sound.audioClip.length);
        buttonImage.color = stopedColor;
    }
}
