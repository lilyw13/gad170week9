using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
     //   collision.gameObject.SetActive(false);
     //   Debug.Log("egg goes brrrr");

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("CHICKEN: mwahahah the chicken does come before the egg");
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }
}
