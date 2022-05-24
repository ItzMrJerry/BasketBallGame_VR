using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 ControllerInput;
    public float Speed;
    public CharacterController controller;
    public Rigidbody rb;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        //rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 Direction = Player.instance.hmdTransform.TransformDirection(new Vector3(ControllerInput.axis.x, 0, ControllerInput.axis.y));
        //transform.position += Speed * Time.deltaTime * Vector3.ProjectOnPlane(Direction,Vector3.up);
        controller.Move(Speed * Time.deltaTime * Vector3.ProjectOnPlane(Direction, Vector3.up) - new Vector3(0,9.81f,0) * Time.deltaTime);
        //rb.AddForce(Speed * Time.deltaTime * Vector3.ProjectOnPlane(Direction, Vector3.up)/* - new Vector3(0, 9.81f, 0) * Time.deltaTime*/);
    }
}
