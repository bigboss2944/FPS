using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretCollision : MonoBehaviour
{
    int count = 5;


    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "PlayerBullet")
        {
            count -= 1;
            if (count < 1)
            {
                //LooseHealth(20);
                //go.getComponent<>
                Destroy(this.gameObject);
            }
            
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
