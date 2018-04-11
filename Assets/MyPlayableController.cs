using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MyPlayableController : MonoBehaviour {

    private PlayableDirector director;

	// Use this for initialization
	void Start () {
        director = GetComponent<PlayableDirector>();
	}
	
    public void startTimelineSequence()
    {
        director.Play();
    }

    public void stopTimelineSequence()
    {
        director.Stop();
    }

    public void pauseTimelineSequence()
    {
        director.Pause();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
