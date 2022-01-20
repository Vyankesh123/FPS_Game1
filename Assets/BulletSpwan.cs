using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpwan : MonoBehaviour
{
    public GameObject bulletPrefab;
    GameObject bulletTempref;
    Rigidbody rb;
  
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletTempref = Instantiate(bulletPrefab);
            bulletTempref.transform.position = transform.position; 
            rb = bulletTempref.GetComponent<Rigidbody>();
            Camera cam = GetComponentInChildren<Camera>();
            rb.velocity = cam.transform.rotation * Vector3.forward * bulletSpeed;
        }
    }
}
