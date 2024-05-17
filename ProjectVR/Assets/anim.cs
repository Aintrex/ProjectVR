using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    private Animation Anim;

    void Start()
    {
        Anim = GetComponent<Animation>();
        Anim.Play();
    }

    void Update()
    {
        if (!Anim.isPlaying)
        {
            Anim.Stop();

        }
    }
}