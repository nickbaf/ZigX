using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backroundMusic : MonoBehaviour
{

    public static backroundMusic theMusic;
    private void Awake()
    {
        if (theMusic == null)
        {
            theMusic = this;
        }
        else if(theMusic!=this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
