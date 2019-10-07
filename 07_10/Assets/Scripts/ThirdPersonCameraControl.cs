using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraControl : MonoBehaviour
{
    float rotationSpeed = 1;
    public Transform target, player;
    float mouseX, mouseY;

    //public Transform obstruction;
    float zoomSpeed = 2f;

    public Material obstructionMaterial;
    
    void Start()
    {
        //obstruction = target;
        Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {
        CamControl();
        //ViewObstructed();
    }
    

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        

        //transform.LookAt(target);

        player.rotation = Quaternion.Euler(0, mouseX, 0);
          
         
    }
    
    /*
    void ViewObstructed()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, target.position - transform.position, out hit, 4.5f))
        {
            
            if (hit.collider.gameObject.tag != "Player") //não deixar o corpo do player transparente
            {
                if(obstruction)
                {
                    if(obstruction != hit.transform)
                    {
                        obstruction = hit.transform;
                        obstructionMaterial = obstruction.gameObject.GetComponent<MeshRenderer>().sharedMaterial;
                        
                        print(obstructionMaterial.name + " " + obstructionMaterial.color);

                        Utillities.ChangeRenderMode(obstruction.gameObject.GetComponent<MeshRenderer>().material, Utillities.BlendMode.Transparent);
                        Color transparent = new Color(0, 0, 0, 0);
                        obstruction.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", transparent);

                        if (Vector3.Distance(obstruction.position, transform.position) >= 3f && Vector3.Distance(transform.position, target.position) >= 1.5f)
                            transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime);
                    }
                }
                
            }
            else
            {
                if(obstruction.gameObject.GetComponent<MeshRenderer>())
                {
                    
                    obstruction.gameObject.GetComponent<MeshRenderer>().material = obstructionMaterial;
                    if (Vector3.Distance(transform.position, target.position) < 4.5f)
                        transform.Translate(Vector3.back * zoomSpeed * Time.deltaTime);
                    obstruction = target;

                }

            }
        }
    } 
    */
}