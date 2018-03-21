using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public static AudioManager instance;

    public Sound[] musicList;
    public Sound[] environmentList;
    public Sound[] weaponList;
    public Sound[] effectsList;
    public Sound[] creaturesList;

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

    //TODO Preencher Grids com audioButtons;
}
