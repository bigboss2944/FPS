using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolScript : MonoBehaviour
{
    public GameObject projectile;
    public Transform posTir;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(projectile, posTir.position, Quaternion.identity);

            go.GetComponent<Rigidbody>().AddForce(posTir.forward * force);

            Destroy(go, 2);
        }
    }
}
