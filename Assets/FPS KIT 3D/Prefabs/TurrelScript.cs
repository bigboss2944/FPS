using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrelScript : MonoBehaviour
{
    public Transform target;
    public GameObject bullet;
    public float force;
    public float reloadTime;
    public Transform posTir;
    public GameObject canon;
    bool canShot = true;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(target.position.x, canon.transform.position.y, target.position.z);
        canon.transform.LookAt(targetPosition);

        float distance = Vector3.Distance(transform.position, target.position);

        if(canShot && distance < 1000000)
        {
            canShot = false;

            GameObject go = Instantiate(bullet, posTir.position, Quaternion.identity);

            go.GetComponent<Rigidbody>().AddForce(posTir.forward * force);

            Destroy(go, 2);

            StartCoroutine("Reload");


        }

        
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);
        canShot = true;
    }
}
