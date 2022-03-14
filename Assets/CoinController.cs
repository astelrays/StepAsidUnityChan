using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private GameObject came;
    // Start is called before the first frame update
    void Start()
    {
        this.came=GameObject.Find("Main Camera");
        this.transform.Rotate(0,Random.Range(0,360),0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0,3,0);
        if(this.transform.position.z<came.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
