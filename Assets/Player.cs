using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float counter = 1f;
    public MeshRenderer a;
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 10f, 0);
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

            if (counter == 4)
            {
                a.material.color = Color.green;
            }

            if (counter == 5)
            {
                a.material.color = Color.cyan;
            }

            if (counter == 6)
            {
                a.material.color = Color.blue;
            }

            counter = counter + 1;
            if (counter==7)
            {
                counter = 1;
            }
        }
    }
    
}
