using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour 
{
    //to complete game, reach the exit 
    public string ExitTargetTagName = "Exit";
    public UnityEngine.Events.UnityEvent OnMazeEnds;
   
    //touching lava kills the player
    public string FailTargetTagName = "Lava";
    public UnityEngine.Events.UnityEvent OnMazeEndFail;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with something");

        if (other.tag == FailTargetTagName)
        {
            Debug.Log("you touched lava. you are dead");
            //this.GetComponent<Animator>().SetTrigger("DieNow");
            OnMazeEndFail.Invoke();
        }

        if (other.tag == ExitTargetTagName)
        {
            Debug.Log("well done. you exited the maze");
            OnMazeEnds.Invoke();
        }
    }
}