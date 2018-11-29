using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private float damage;

    private void OnCollisionEnter2D(Collision2D collision) {
        var collider = collision.collider;
        if (collider.name.Contains("Bot")) {
            collider.gameObject.GetComponent<ChasisModule>().Damage(damage);
        }
        Destroy(gameObject);
    }

    public void SetDamage(float damage) {
        this.damage = damage;
    }
}
