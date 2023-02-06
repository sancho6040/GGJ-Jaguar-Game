using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleCounter : MonoBehaviour
{
    public Text points;
    public int apples;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        points.text = apples.ToString();
    }

    public void eat()
    {
    }
}
