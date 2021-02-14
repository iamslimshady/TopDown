using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform fire;
    public GameObject bulletPrefab;
    public AudioClip shootSFX;
    [Range(0, 2)] public float volume;
    public float bulletForce = 15f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            AudioSource.PlayClipAtPoint(shootSFX, Camera.main.transform.position, volume);
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, fire.position, fire.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(fire.right * bulletForce, ForceMode2D.Impulse);

    }

}

