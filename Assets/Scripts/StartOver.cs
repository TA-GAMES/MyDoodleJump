using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOver : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the player to start over the level")]
    [SerializeField] string triggeringTag;
    [SerializeField] string sceneName;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == triggeringTag && enabled)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
