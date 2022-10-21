using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMovement : MonoBehaviour
{
    [SerializeField] float carSpeed,rotateRate;
    public Rigidbody rb;
    public Touch finger;
    bool L, R;
    public Transform lw, rw;
    public SpawnManager spawnManager;
    //private int currentScn;
    //[SerializeField] Transform turnLeft, turnRight;
    
    void Start()
    {
      carSpeed = 20;
      rb = GetComponent<Rigidbody>();
      
    }

    
    void Update()
    {
        rb.velocity = transform.forward * carSpeed;
   
    //if (GameManager.instance.gameEnd != true)
            //{
                if (Input.touchCount > 0)
                {
                    finger = Input.GetTouch(0);

                    if (finger.phase == TouchPhase.Moved)
                    {
                        if (finger.deltaPosition.x > 0f)
                        {
                            L = true;
                            R = false;
                           // rw.rotation = Quaternion.Lerp(rw.rotation, turnRight.rotation, Time.deltaTime * carSpeed * 0.1f);
                            //lw.rotation = Quaternion.Lerp(lw.rotation, turnRight.rotation, Time.deltaTime * carSpeed * 0.1f);
                           
                            
                        }
                    }
                    if (finger.deltaPosition.x < 0f)
                    {
                        L = false;
                        R = true;
                        //rw.rotation = Quaternion.Lerp(rw.rotation, turnLeft.rotation, Time.deltaTime * carSpeed * 0.1f); 
                        //lw.rotation = Quaternion.Lerp(lw.rotation, turnLeft.rotation, Time.deltaTime * carSpeed * 0.1f);
                        
                        
                    }


                    

                }
            //}
        

        if (R == true) 
            {
                
                rb.velocity = transform.forward * carSpeed;
                transform.Rotate(0f, -rotateRate * Time.deltaTime, 0f);


            }
            if (L == true)
            {
                
                rb.velocity = transform.forward * carSpeed;
                transform.Rotate(0f, rotateRate * Time.deltaTime, 0f);
            }



         


        /*if (GameManager.instance.gameEnd == true)
            {
                rotateRate = 0f;
            }*/


    }

        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.layer == 6) //Block Layer
                {
                    
                    carSpeed = 0;
                   // Debug.Log("if icine girdi");
                    rb.constraints = RigidbodyConstraints.FreezePosition;
                    rotateRate = 0f;
                    GameManager.instance.gameEnd = true;
                   // SceneManager.LoadScene("SampleScene");
                   // currentScn= SceneManager.GetActiveScene().buildIndex;
                   // SceneManager.LoadScene(currentScn);
                    
                }
        }

        private void OnTriggerEnter(Collider other){
            spawnManager.SpawnTriggerEntered();
        }

    
}

