using UnityEngine;
using UnityEngine.InputSystem;



public abstract class EndGame : PlayerControl//abstract on ne peux pas instantier sur un objet car on n'a pas de methodes spécifique
{

private float speed;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            speed=0;
        }
    }

}
