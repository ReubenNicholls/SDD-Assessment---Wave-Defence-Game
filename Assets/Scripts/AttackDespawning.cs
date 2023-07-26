using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDespawning : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Invoke("Destroy", 3.0f);
    }
    public void Despawn()
    {
        Destroy(this);
    }
}
