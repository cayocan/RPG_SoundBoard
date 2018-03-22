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
}
