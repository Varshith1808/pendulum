using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_angle : MonoBehaviour
{
    public GameObject input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void button()
    {
        if (input.active)
        {
            input.SetActive(false);
        }
        else
        {
            input.SetActive(true);
        }
    }
}
