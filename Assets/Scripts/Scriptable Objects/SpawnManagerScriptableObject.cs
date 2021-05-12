using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SpawnManagr", menuName = "AI/SpawnMenu")]
public class SpawnManagerScriptableObject : ScriptableObject
{

    public string prefabName;
    public int spawnCount;
    public float timeBetweenSpawns;

    
}
