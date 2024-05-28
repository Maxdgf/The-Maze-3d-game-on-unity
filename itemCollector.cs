using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    public GameObject tmor;
    public Text ItemCountText;
    public Text preduprejdenie;
    public int ItemsCollected;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("iteem"))
        {
            ItemsCollected++;
            ItemCountText.text = "Diamonds: " + ItemsCollected;
            Destroy(other.gameObject);
        }

        if (ItemsCollected == 80)
        {
            Animator tm = tmor.GetComponent<Animator>();
            tm.enabled = true;
            preduprejdenie.text = "Бегите к выходу!";
               
        }

        if (other.CompareTag("gaate"))
        {
            SceneManager.LoadScene(4);
        }

        if (other.CompareTag("monster"))
        {
            SceneManager.LoadScene(3);
        }

    }
    
    

}
