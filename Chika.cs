using UnityEngine;
using UnityEngine.SceneManagement;
public class Iriguchi : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject.Find("PF Player").transform.position = new Vector2(58, -8);
            Debug.Log("atari");
    } 

    
}
