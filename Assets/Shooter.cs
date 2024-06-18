using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Vector3 direction;
    public Transform bulletTransform;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            var bullet = Instantiate(bulletPrefab, bulletTransform.position, bulletTransform.rotation);
            Vector3 direction = new Vector3(1, 0);
        }
        
        bulletTransform.position = bulletTransform.position + (direction * bulletSpeed * Time.deltaTime);
    }
}
  
