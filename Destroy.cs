using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Удаляет объект один раз в начале игры
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}