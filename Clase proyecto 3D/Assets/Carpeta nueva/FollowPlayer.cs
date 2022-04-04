using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour //Seguir a jugador
{
    public GameObject player; //Objeto a seguir

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }

    public Vector3 offset = new Vector3(0,5,0); 
}
