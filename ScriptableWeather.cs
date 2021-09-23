using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weather {

    public string name;
    public string description;
    public string effect;
    public bool canBeStacked;
    public int duration;

}

[CreateAssetMenu(menuName = "Scriptable Object/Weather/New", fileName = "rename me")]
public class ScriptableWeather : ScriptableObject {

    public List<Weather> allWeatherTypes = new List<Weather>();

}
 
