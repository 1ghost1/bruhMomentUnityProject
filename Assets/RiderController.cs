using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiderController : MonoBehaviour
{
    [SerializeField] float steerMulti = 100;
    [SerializeField] float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmt = (Input.GetAxis("Horizontal") * steerMulti) * Time.deltaTime;
        float moveAmt = (Input.GetAxis("Vertical") * moveSpeed) * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmt);
        transform.Translate(0, moveAmt, 0);
        

     }
}
