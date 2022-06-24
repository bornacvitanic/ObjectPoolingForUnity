using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectPoolPrefabList", menuName = "ScriptableObjects/Pooling/ObjectPoolPrefabList")]
public class ObjectPoolPrefabList : ScriptableObject
{
    [System.Serializable]
    public class PoolPrefabs {
        public GameObject prefab;
        public int frequency;
    }
    public List<PoolPrefabs> poolPrefabs;
}
