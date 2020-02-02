using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level : MonoBehaviour {
    //parameters
    [SerializeField] int breakableBlocks;

    //cached materials
    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    public void countBreakableBlocks()
    { 
        breakableBlocks++;     
    }

    public void destroyBlocks()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
