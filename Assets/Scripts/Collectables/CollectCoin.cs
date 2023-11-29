using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;

    void OnTriggerEnter(Collider other) {
        coinFX.Play();
        CollectableController.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
