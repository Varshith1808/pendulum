using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increase : MonoBehaviour

{
    public GameObject Cube;
    Vector3 temp;
    // Start is called before the first frame update
   public void Start1()
    {
        temp = Cube.transform.localScale;
         temp.x += 1;
         Cube.transform.localScale = temp;

    }

    // Update is called once per frame
    void Update()
    {
        
        //Cube.transform.localScale;

    }
}
