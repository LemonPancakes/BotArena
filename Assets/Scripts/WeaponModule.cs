using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponModule : MonoBehaviour {

    public GameObject bulletPrefab;

    public float weaponDamage;
    public float weaponRange; // TODO: use
    public float projectileVelocity;
    public float projectileLifeTime;

    private void Update() {
        LookAtMouse();
    }

    private void LookAtMouse() {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - gameObject.transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        gameObject.transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }

    public void Fire() {
        var bulletClone = (GameObject)Instantiate(bulletPrefab, gameObject.transform.position + gameObject.transform.up * 0.5f, gameObject.transform.rotation);
        bulletClone.GetComponent<Rigidbody2D>().velocity = bulletClone.transform.up * projectileVelocity;

        bulletClone.GetComponent<Bullet>().SetDamage(weaponDamage);

        Destroy(bulletClone, projectileLifeTime);
    }
}
