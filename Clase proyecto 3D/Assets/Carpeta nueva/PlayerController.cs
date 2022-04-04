using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Modificador
        [SerializeField, Range(0,200), Tooltip("Modifica la velocidad del objeto")] private float velocidad=15.2f;
    [Range(0, 100), SerializeField] float turnSpeed = 20f;

    public float horizontalInput;
    public float verticalInput;
    // Update is called once per frame
    void Update()
    {
        Debug.Log("El objeto esta actualizando su estado" + gameObject.name);
        //Movimiento vehiculo 
        this.transform.Translate(Vector3.forward * verticalInput * velocidad *Time.deltaTime);
        this.transform.Rotate(Vector3.up*horizontalInput*turnSpeed*Time.deltaTime);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }
}