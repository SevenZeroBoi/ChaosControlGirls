using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CursorMoving : MonoBehaviour
{
    public float moveSpeed;
    public float hitboxSize;
    public string currentPointing;

    public bool isTriggered;
    void Movement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + new Vector3 (moveX, moveY).normalized * Time.deltaTime * moveSpeed;
    }

    float clickcooldown = 5;
    private void Update()
    {
        Movement();
        //Collider2D overlap = Physics2D.OverlapCircle(transform.position, hitboxSize);
        
        if (clickcooldown <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isTriggered = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                isTriggered = false;
                clickcooldown = 2;
            }
        }
        else
        {
            clickcooldown -= Time.deltaTime;
        }
        /*if (currentPointing != null)
        {
            GameObject obj = GameObject.Find(currentPointing);
            obj.GetComponent<Main>
        }*/
    }

    /*
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, hitboxSize);
    */
}
