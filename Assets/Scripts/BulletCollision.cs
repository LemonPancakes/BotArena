using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {


    private void OnCollisionEnter2D(Collision2D collision) {
        var collider = collision.collider;
        if (collider.name.Contains("Bot")) {
            collider.gameObject.GetComponent<ChasisModule>().Damage();
            Destroy(collider.gameObject);
            Destroy(gameObject);
        } else if (!collider.name.Contains("Bot")) {
            Destroy(gameObject);
        }
    }
}
