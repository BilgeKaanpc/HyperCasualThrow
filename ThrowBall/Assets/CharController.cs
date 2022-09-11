using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharController : MonoBehaviour
{

    [SerializeField] ScreenTouchController input;


    [Range(200, 2000)] [SerializeField] private float moveSpeed;
    private Rigidbody myRigidbody;

    private Vector3 offset;
    public GameObject cam,player;

    private void Awake()
    {
        offset = cam.transform.position - player.transform.position;
        myRigidbody = player.GetComponent<Rigidbody>();
    }
    void Move(Vector3 direction)
    {
        myRigidbody.velocity = direction * moveSpeed * Time.deltaTime;
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        var direction = new Vector3(input.Direction.x, 0, input.Direction.y);
        Move(direction);
    }

    private void LateUpdate()
    {
        cam.transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
