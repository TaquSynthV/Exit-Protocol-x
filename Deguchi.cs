using UnityEngine;

public class Deguchi : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject.Find("PF Player").transform.position = new Vector2(4, -7);
        Debug.Log("atari");
    }


}

