using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public static AudioManager instance;

    [SerializeField]
    private Sound[] musicList;
    [SerializeField]
    private Sound[] environmentList;
    [SerializeField]
    private Sound[] weaponList;
    [SerializeField]
    private Sound[] effectsList;
    [SerializeField]
    private Sound[] creaturesList;

    void Awake()
    {//Singleton statement.
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        AudioManagerSetup();
    }

    void AudioManagerSetup()
    {
        //Configure Music List.
        foreach (Sound sound in instance.musicList)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();
            sound.Source.clip = sound.audioClip;
            sound.Source.loop = sound.loop;
        }

        //Configure Environment List.
        foreach (Sound sound in instance.environmentList)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();
            sound.Source.clip = sound.audioClip;
            sound.Source.loop = sound.loop;
        }

        //Configure Weapon List.
        foreach (Sound sound in instance.weaponList)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();
            sound.Source.clip = sound.audioClip;
            sound.Source.loop = sound.loop;
        }

        //Configure Effects List.
        foreach (Sound sound in instance.effectsList)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();
            sound.Source.clip = sound.audioClip;
            sound.Source.loop = sound.loop;
        }

        //Configure Creatures List.
        foreach (Sound sound in instance.creaturesList)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();
            sound.Source.clip = sound.audioClip;
            sound.Source.loop = sound.loop;
        }
    }

    void PlaySound(Sound sound)
    {
        sound.Source.Play();
    }

    void StopSound(Sound sound)
    {
        sound.Source.Stop();
    }
}
