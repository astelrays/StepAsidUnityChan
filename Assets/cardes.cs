using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardes : MonoBehaviour
{
    private GameObject came;
    // Start is called before the first frame update
    void Start()
    {
        this.came=GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z<this.came.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
