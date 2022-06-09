using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Crash : MonoBehaviour
{
    [SerializeField] float delay;
    [SerializeField] ParticleSystem crashed;
    [SerializeField] AudioClip crashsfx;
    bool hascrashed= false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && !hascrashed)
        {
            hascrashed = true;
            FindObjectOfType<Movement>().Disablecontrols();
            crashed.Play();
            GetComponent<AudioSource>().PlayOneShot(crashsfx);
            Invoke("ReloadScence", delay);
        }
    }
    void ReloadScence()
    {
        SceneManager.LoadScene(0);
    }
}
