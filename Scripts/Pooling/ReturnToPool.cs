using UnityEngine;

public class ReturnToPool : MonoBehaviour
{
    [HideInInspector] public string prefabName;
    [HideInInspector] public bool returnOnDisable = false;

    private void OnEnable()
    {
        //hideFlags = HideFlags.HideInInspector;
    }

    private void OnDisable()
    {
        if(returnOnDisable)
        {
            Invoke("Return", 0.01f);
        }
    }

    public void Return()
    {
        if(ObjectPooler.SharedInstance == null)
        {
            return;
        }
        if(!gameObject.transform.parent == ObjectPooler.SharedInstance.transform) //Check if already in pool
        {
            ObjectPooler.SharedInstance.ReturnObject(gameObject);
        }
    }
}
