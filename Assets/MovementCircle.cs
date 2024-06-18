using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCircle : MonoBehaviour
{
    public Transform bulletTransform;
    public Vector3 bulletVector;
    public float bulletSpeed =30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (bulletVector * bulletSpeed * Time.deltaTime);
    }
}
