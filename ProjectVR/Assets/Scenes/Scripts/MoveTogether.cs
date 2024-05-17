using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTogether : MonoBehaviour
{
    public GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetObject != null)
        {
            transform.position = targetObject.transform.position;
        }
    }
}
