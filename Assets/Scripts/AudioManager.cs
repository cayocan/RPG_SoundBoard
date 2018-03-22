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

    public Sound[] MusicList
    {
        get
        {
            return musicList;
        }
    }

    public Sound[] EnvironmentList
    {
        get
        {
            return environmentList;
        }
    }

    public Sound[] WeaponList
    {
        get
        {
            return weaponList;
        }
    }

    public Sound[] EffectsList
    {
        get
        {
            return effectsList;
        }
    }

    public Sound[] CreaturesList
    {
        get
        {
            return creaturesList;
        }
    }

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
        foreach (Sound sound in instance.MusicList)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();
            sound.Source.clip = sound.audioClip;
            sound.Source.loop = sound.loop;
        }

        //Configure Environment List.
        foreach (Sound sound in instance.EnvironmentList)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();
            sound.Source.clip = sound.audioClip;
            sound.Source.loop = sound.loop;
        }

        //Configure Weapon List.
        foreach (Sound sound in instance.WeaponList)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();
            sound.Source.clip = sound.audioClip;
            sound.Source.loop = sound.loop;
        }

        //Configure Effects List.
        foreach (Sound sound in instance.EffectsList)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();
            sound.Source.clip = sound.audioClip;
            sound.Source.loop = sound.loop;
        }

        //Configure Creatures List.
        foreach (Sound sound in instance.CreaturesList)
        {
            sound.Source = gameObject.AddComponent<AudioSource>();
            sound.Source.clip = sound.audioClip;
            sound.Source.loop = sound.loop;
        }
    }

    public void PlaySound(Sound sound)
    {
        sound.Source.Play();
    }

    public void StopSound(Sound sound)
    {
        sound.Source.Stop();
    }
}
