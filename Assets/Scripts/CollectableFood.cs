using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableFood : MonoBehaviour
{
    public float apples;
    AppleCounter appleCounter;
    public Text points;
    // Start is called before the first frame update
    void Start()
    {
        apples = 20f;
        points.text = "Manzanas restantes: " + apples.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Debug.Log("Ñam");
            Destroy(other.gameObject);
            apples = apples - 0.5f;
            //other.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        points.text = "Manzanas restantes: " + apples.ToString();
    }
}
