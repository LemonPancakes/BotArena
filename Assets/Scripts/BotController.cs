using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour {

    private Rigidbody2D body;
    private WeaponModule weaponModule;
    private ChasisModule chasisModule;

    private void Start() {
        body = GetComponent<Rigidbody2D>();
        weaponModule = GetComponent<WeaponModule>();
        chasisModule = GetComponent<ChasisModule>();
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        body.AddForce(movement * chasisModule.speed);
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            weaponModule.Fire();
        }
    }
}
