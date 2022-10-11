using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public CharacterController player;
    public float velocidad;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical =Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        player.Move(new Vector3(horizontal, 0, vertical) * velocidad * Time.deltaTime);
    }
}
