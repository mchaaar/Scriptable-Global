using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Genes/New Gene", fileName = "rename me")]
public class ScriptableGene : ScriptableObject{

    public string name = "";
    public string type = "";
    public int level;
    public bool isHereditary;

}
 
