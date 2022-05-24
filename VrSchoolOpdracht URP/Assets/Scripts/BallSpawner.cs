using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    private bool BallOnPad = true;
    public GameObject Ball;
    public Transform SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPoint = GameObject.Find("SpawnPoint").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NewBall()
    {
        StartCoroutine(ExampleCoroutine());
        Debug.Log("Test");
    }
    IEnumerator ExampleCoroutine()
    {
        
        yield return new WaitForSeconds(1);
        if (!BallOnPad)
        {
            Instantiate(Ball, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
            Debug.Log("Spawn BasketBall");
        }
    }
    //public IEnumerator NewBasketBall()
    //{
        
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Ball")
        {

            BallOnPad = true;
            Debug.Log("Ball Entered");
        }
        Debug.Log("ObjectEnterd");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.tag == "Ball")
        { 
            NewBall();
            BallOnPad = false;
            Debug.Log("Ball Left");
        }
        Debug.Log("ObjectLeft");
    }
}
