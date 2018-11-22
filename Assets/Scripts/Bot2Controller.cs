using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot2Controller : MonoBehaviour {

    public float speed;

    private Rigidbody2D body;

    public GameObject bulletPrefab;

    private void Start() {
        body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Fire();
        }
    }

    void Fire() {
        var bullet = (GameObject)Instantiate(bulletPrefab, body.transform.position + body.transform.up * 0.5f, body.transform.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * 6;

        Destroy(bullet, 2.0f);
    }
}
