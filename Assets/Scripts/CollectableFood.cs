using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableFood : MonoBehaviour
{
    public int apples;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Debug.Log("Ñam");
            apples = apples + 1;
            other.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
