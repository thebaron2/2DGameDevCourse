using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // config parameters
    [SerializeField] int breakableBlocks;   // Serialized for debug

    // cached references
    SceneLoader mySceneLoader;

    private void Start()
    {
        mySceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            mySceneLoader.LoadNextScene();
        }
    }
}
