using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    private static int _Totalseeds = 0;

    //Static Constructor to load data from PlayerPrefs
    static GameData()
    {
        _Totalseeds = PlayerPrefs.GetInt("Totalseeds", 0);
    }

    public static int Totalseeds
    {
        get
        {
            return _Totalseeds;
        }
        set
        {
            PlayerPrefs.SetInt("Totalseeds", (_Totalseeds = value));
        }
    }

}
