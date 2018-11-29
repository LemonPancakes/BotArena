using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasisModule : MonoBehaviour {

    public float health;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Damage(float damage) {
        float finalHealth = this.health - damage;
        print(finalHealth);
        if (finalHealth > 0.0f) {
            this.health = finalHealth;
        } else {
            this.health = 0.0f;
            this.Death();
        }
    }

    void Death() {
        Destroy(this.gameObject);
    }
}
