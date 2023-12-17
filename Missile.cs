using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        Destroy(gameObject, 3);
    }

    void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=transform.forward *speed * Time.deltaTime;
    }
}