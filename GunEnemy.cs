using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEnemy : Sounds
{
    public GameObject bullet;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;
    void Update()
    {
        
        if (timeBtwShots <= 0)
        {
            Instantiate(bullet, shotPoint.position, transform.rotation);
            timeBtwShots = startTimeBtwShots;
            PlaySound(sounds[0]);
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
