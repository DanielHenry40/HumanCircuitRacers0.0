using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public float speed;

       // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform.position);
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnCollisionStay(Collision obj)
    {
        if (obj.gameObject.name == "Player")
        {
            speed = 0f;
        }
        else
        {
            speed = 5f;
        }
    }
}
