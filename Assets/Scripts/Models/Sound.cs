using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound {
    public string name;
    //public int id;
    public AudioClip audioClip;
    public bool loop;
    public SoundType soundType;

    [HideInInspector]
    private AudioSource source;

    public AudioSource Source
    {
        get
        {
            return source;
        }

        set
        {
            source = value;
        }
    }

    public enum SoundType
    {
        Music,
        Environment,
        Weapon,
        Effects,
        Creatures,
    }
}
