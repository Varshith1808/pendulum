using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour
{
    public GameObject input1;
    public GameObject input2;
    public GameObject input3;
    public GameObject input4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
   public void change() {
        if (input1.active)
        {
            input1.SetActive(false);
        }
        else
        {
            input1.SetActive(true);
        }
        if (input2.active)
        {
            input2.SetActive(false);
        }
        else
        {
            input2.SetActive(true);
        }
        if (input3.active)
        {
            input3.SetActive(false);
        }
        else
        {
            input3.SetActive(true);
        }
        if (input4.active)
        {
            input4.SetActive(false);
        }
        else
        {
            input4.SetActive(true);
        }
      
    }
}
