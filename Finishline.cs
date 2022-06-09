using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
    [SerializeField] float delay;
    [SerializeField] ParticleSystem finish;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            finish.Play();
            Invoke("ReloadScence", delay);
        }
    }

    void ReloadScence()
    {
        SceneManager.LoadScene(0);
    }
}
