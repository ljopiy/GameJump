using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy2 : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    private int damage = 1;
    public LayerMask whatIsSolid;
    public GameObject bulletEffect;

    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("player"))
                hitInfo.collider.GetComponent<playerMove4>().TakeDamage(damage);

            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
