using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left")){
            gameObject.transform.Translate(0, 0, 100f * Time.deltaTime);
        }

        if(Input.GetKey("right")){
            gameObject.transform.Translate(0, 0, -100 * Time.deltaTime);
        }

        if(Input.GetKey("up")){
            gameObject.transform.Translate(100 * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("down")){
            gameObject.transform.Translate(-100 * Time.deltaTime, 0, 0);
        }
    }
}
