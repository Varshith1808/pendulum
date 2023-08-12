using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_enable : MonoBehaviour
{
    public GameObject input;
    script_enable script1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void script_changr()
    {
         input.GetComponent<swing>().enabled=true;
        
    }
}