using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject bullet;
    public GameObject points;
    public AudioSource source;
    private float fireRate = 1f;
    private float nextFire = 1f;
    private float fireRate2 = 2.5f;
    private float nextFire2 = .5f;
    private float switchRate = 1f;
    private float nextSwitch = 0.0f;
    private float direction = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //handle firing projectiles at different times
        transform.position = new Vector2(transform.position.x + (.05f * direction), transform.position.y);
        if(Time.time > nextFire)
        {
            Instantiate(bullet, new Vector2(transform.position.x, transform.position.y-1), transform.rotation);
            nextFire = Time.time + fireRate;
        }
        if (Time.time > nextFire2)
        {
            Instantiate(points, new Vector2(transform.position.x, transform.position.y - 1), transform.rotation);
            nextFire2 = Time.time + fireRate2;
        }
        if (Time.time > nextSwitch)
        {
            if(Random.Range(0,100)<30)
            {
                direction *= -1;
            }
            nextSwitch = Time.time + switchRate;
        }
        //allows for teleporting
        if (transform.position.x < -10 || transform.position.x > 10)
        {
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
            nextFire2 += 1f;
        }
        fireRate2 = Random.Range(0, 2.5f);
        fireRate = Random.Range(1, 2);

    }
    
}
