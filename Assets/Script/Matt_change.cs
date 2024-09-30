using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matt_change : MonoBehaviour
{
    private float counter = 1f;
    public MeshRenderer a;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (counter == 1)
            {
                a.material.color = Color.magenta;
            }

            if (counter == 2)
            {
                a.material.color = Color.red;
            }

            if (counter == 3)
            {
                a.material.color = Color.yellow;
            }

            counter = counter + 1;
        }
    }
}
