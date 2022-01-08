using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    private GameObject instance;
    private List<GameObject> instances = new List<GameObject>();
    private float timer;
    private int counter = 1;

    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - timer > 5)
        {
            if(instance == null)
            {
                for(int i = 0; i < counter; i++)
                {
                    instance = ObjectPooler.SharedInstance.Instantiate(prefab); // Asking the pooler for an instance of the prefab.
                    instances.Add(instance);
                }
                counter++;
            }
            else
            {
                for(int i = instances.Count-1; i>=0; i--)
                {
                    instances[i].SetActive(false); // To return object to pool, just disable it, the attached ReturnToPool sctipt will handle the rest.
                    instances.Remove(instances[i]);
                }
                instance = null;
            }
            timer = Time.time;
        }
    }
}
