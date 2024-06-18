using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Vector3 direction;           //Direction the bullet will go.
    public Transform bulletTransform;   //The Game Object that the Prefab will adhere to.
    public GameObject bulletPrefab;     //The asset I will use to attach to the Game Object.
    public float bulletSpeed = 30f;     //The eventual Speed that the bullet will go.

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            //setting the direction of the bullet.
            direction = Vector3.right;

            //Bullet is created when the Spacebar is pressed.
            var bullet = Instantiate(bulletPrefab, bulletTransform.position, bulletTransform.rotation);
            
            //Movement equation from the movement script, altered for use on the bullet's movement.
            bulletTransform.position = bulletTransform.position + (direction * bulletSpeed * Time.deltaTime);
            
        }
    }
}
  
