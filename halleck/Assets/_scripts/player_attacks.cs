using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//attached to player weapon ie staff

public class player_attacks : MonoBehaviour
{
    //public float detectradius;
    
    public float pushforce;


    private bool insidetrig = false;
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {

            
            if (!insidetrig)
            {
                //meele attack animation
                //pushenemy();
            }
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        checkforinp(other);

    }
  /*  private void OnTriggerEnter(Collider other)
    {
        checkforinp(other);

    }*/


    void checkforinp(Collider other)
    {
        if (Input.GetButtonDown("Fire1"))
        {

            if (other.gameObject.tag.Equals("cubenemy"))
            {

                insidetrig = true;
                damagenemy();
                pushenemy(other.gameObject);
            }

        }

        insidetrig = false;

    }


    //to push/attack enemy 

    void damagenemy()
    {



    }

    void pushenemy(GameObject obj)
    {

        //obj.transform.position += this.GetComponentInParent<Transform>().forward * Time.deltaTime * pushforce;
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        rb.AddExplosionForce(pushforce, transform.position, 5f);//, 1f, ForceMode.Impulse);
    }
}
