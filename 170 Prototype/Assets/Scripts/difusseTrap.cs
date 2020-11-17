using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difusseTrap : MonoBehaviour
{
    public int touched_water = 0;

    void OnTriggerEnter2D(Collider2D col){
      if(col.gameObject.layer == 4){
        touched_water += 1;
      }
      if(touched_water == 15){
        Collider2D selfCollider = GetComponent<Collider2D>();
        selfCollider.isTrigger = false;
        GetComponent<Renderer>().material.color = Color.blue;
      }
    }
}
