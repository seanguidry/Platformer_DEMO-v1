using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform bulletTransform;   //The Game Object that the Prefab will adhere to.
    public GameObject bulletPrefab;     //The asset I will use to attach to the Game Object.  

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //Bullet is created while the Spacebar is pressed.
            var bullet = Instantiate(bulletPrefab, bulletTransform.position, bulletTransform.rotation);
        }
    }
}
  
