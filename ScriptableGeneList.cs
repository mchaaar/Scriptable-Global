using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Genes/New List", fileName = "rename me")]
public class ScriptableGeneList : ScriptableObject{

    public List<ScriptableGene> myGenes = new List<ScriptableGene>();

}

