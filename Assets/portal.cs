using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour {

    public Transform Point;
    // Use this for initialization
    void Start () {

    }
    internal protected void OnTriggerEnter(Collider other)
    {
        other.transform.root.position = Point.position;
    }

    // Update is called once per frame
    void Update ()
    {
    }
}
