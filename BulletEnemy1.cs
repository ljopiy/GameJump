using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy1 : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;
    public GameObject bulletEffect;

    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("player"))
                hitInfo.collider.GetComponent<PlayerMove3>().TakeDamage(damage);


            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
