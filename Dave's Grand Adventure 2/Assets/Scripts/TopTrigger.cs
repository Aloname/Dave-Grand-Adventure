using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopTrigger : MonoBehaviour
{
    [SerializeField] private BoxCollider2D midCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            midCollider.enabled = true;
        }
    }
}
