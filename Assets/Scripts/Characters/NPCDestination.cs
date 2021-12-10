using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination : MonoBehaviour
{
    public int trigNum; 

     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            if (trigNum ==4){
                trigNum =0;
            }
            
            if (trigNum==3){
                // Move the position of the object 
                this.gameObject.transform.position = new Vector3(152, 2, 85);
                trigNum = 4;
            }

            if (trigNum==2){
                // Move the position of the object 
                this.gameObject.transform.position = new Vector3(152, 2, 166);
                trigNum = 3;
            }

             if (trigNum==1){
                // Move the position of the object 
                this.gameObject.transform.position = new Vector3(92, 2, 166);
                trigNum = 2;
            }

            if (trigNum==0){
                // Move the position of the object 
                this.gameObject.transform.position = new Vector3(92, 2, 85);
                trigNum = 1;
            }
        }
    }
}
