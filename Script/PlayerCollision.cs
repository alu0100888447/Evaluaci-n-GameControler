using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement playerMovement;
	public float power = 500;

    private void Start()
    {
        GameController.IncrementPower += IncrementPower;
        GameController.DecrementPower += DecrementPower;
        GameController.EndGame += End;
		GameController.Power += MorePower;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
			GameController.Decrement();
			GameController.MoverObjetoB ();	
        }
        if (collision.collider.tag == "NegativeObstacle")
        {
			GameController.Increment();
			GameController.PowerBall();
			GameController.ColorB ();
        }
		if (collision.collider.tag == "ObstacleA") 
		{
			
		}
        if (collision.collider.name == "End")
        {
            GameController.End();
        }
    }

	private void MorePower () {
		power *= 1.5f;
	}

    private void IncrementPower ()
    {
        playerMovement.forwardForce += power;
    }

    private void DecrementPower ()
    {
        playerMovement.forwardForce -= power;
    }

    private void End ()
    {
        playerMovement.enabled = false;
    }
}
