using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {
    public static GridManager instance;

    public GameObject musicGrid;
    public GameObject environmentGrid;
    public GameObject weaponGrid;
    public GameObject effectsGrid;
    public GameObject creaturesGrid;
    [Space(10)]
    public GameObject buttonPrefab;

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
    }

    private void Start()
    {
        PopulateButtonGrids();
    }

    void PopulateButtonGrids()
    {
        foreach (var item in AudioManager.instance.MusicList)
        {
            SoundButton soundButton = Instantiate(buttonPrefab, musicGrid.transform).GetComponentInChildren<SoundButton>();
            soundButton.Sound = item;
        }

        foreach (var item in AudioManager.instance.EnvironmentList)
        {
            SoundButton soundButton = Instantiate(buttonPrefab, environmentGrid.transform).GetComponentInChildren<SoundButton>();
            soundButton.Sound = item;
        }

        foreach (var item in AudioManager.instance.WeaponList)
        {
            SoundButton soundButton = Instantiate(buttonPrefab, weaponGrid.transform).GetComponentInChildren<SoundButton>();
            soundButton.Sound = item;
        }

        foreach (var item in AudioManager.instance.EffectsList)
        {
            SoundButton soundButton = Instantiate(buttonPrefab, effectsGrid.transform).GetComponentInChildren<SoundButton>();
            soundButton.Sound = item;
        }

        foreach (var item in AudioManager.instance.CreaturesList)
        {
            SoundButton soundButton = Instantiate(buttonPrefab, creaturesGrid.transform).GetComponentInChildren<SoundButton>();
            soundButton.Sound = item;
        }
    }
}
