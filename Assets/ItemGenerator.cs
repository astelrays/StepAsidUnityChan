using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    private GameObject maincamera;

    private GameObject coneclone;

    private GameObject coinclone;

    private GameObject carclone;
    public GameObject unitychan;
    private int startPos=80;
    private int goalPos=360;
    private float posRange=3.4f;
    
 
    // Start is called before the first frame update
     void Start()
    {
        
     
        this.maincamera=GameObject.Find("Main Camera");
        unitychan=GameObject.Find("unitychan");
            for (int i=startPos;i<goalPos;i +=15) 
         {
           int num=Random.Range(1,11);
          if(num<=2)
          {  
           
            

            
             for(float j=-1;j<=1;j+=0.4f)
             {
               GameObject cone =Instantiate(conePrefab);
              
               cone.transform.position=new Vector3(4*j,cone.transform.position.y,i);
              
             }
            
          }
         
         else
          {
              for(int j=-1;j<=1;j++)
              {
                  int item=Random.Range(1,11);
                  int offsetZ=Random.Range(-5,6);
                  if(1<=item&&item<=6)
                  {
                      GameObject coin =Instantiate(coinPrefab);
                      coin.transform.position=new Vector3(posRange*j,coin.transform.position.y,i+offsetZ);

                  }
                  else if(7<=item&&item<=9)
                  {
                      GameObject car =Instantiate(carPrefab);
                      car.transform.position=new Vector3(posRange*j,car.transform.position.y,i+offsetZ);
                  }
              }
          }

         }
     
        
        
         
        
     
        
     
        
        
    }

    // Update is called once per frame
    void Update()
    {
        coneclone =GameObject.Find("TrafficConePrefab(Clone)");

        coinclone=GameObject.Find("CoinPrefab(Clone)");

        carclone=GameObject.Find("CarPrefab(Clone)");
       

      
        this.maincamera=GameObject.Find("Main Camera");
       if(coneclone.transform.position.z<maincamera.transform.position.z)
        {
           Destroy(coneclone);
        }
        if(coinclone.transform.position.z<maincamera.transform.position.z)
        {
            Destroy(coinclone);
        }
        if(carclone.transform.position.z<maincamera.transform.position.z)
        {
            Destroy(carclone);
        }
    }
}
