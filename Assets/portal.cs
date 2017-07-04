using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour {

    public Transform Point;
    public Collider person;
    // Use this for initialization
    void Start () {

    }
    internal protected void OnTriggerEnter(Collider other)
    {
        if (other.Equals(person))
        {
            other.transform.root.position = Point.position;
            Debug.Log("传送成功");
        }
    }

    // Update is called once per frame
    void Update ()
    {
    }
}
