using UnityEngine;
using System.Collections;

public class MidiEventTrigger : MonoBehaviour
{

    public bool[] instrumentFilter = new bool[129];
 	public bool[] noteFilter = new bool[128];
    private bool _noteOn = false;
	
	public void Play()
	{
		//Debug.Log("MidiEventTrigger - Play");
        _noteOn = false;
        OnPlay();
	}

	public void Pause()
	{
		//Debug.Log("MidiEventTrigger - Pause");
        OnPause();
	}

	public void Resume()
	{
		//Debug.Log("MidiEventTrigger - Resume");
        OnResume();
	}

	public void Stop()
	{
		//Debug.Log("MidiEventTrigger - Stop");
        OnStop();
	}

	public void NoteOn(int instrument, int noteNumber)
	{
		//Debug.Log(string.Format("MidiEventTrigger - NoteOn {0:d}, {1:d}", instrument, noteNumber));
        if(_noteOn == false)
		{
			_noteOn = true;

			if(instrumentFilter[instrument] == true && noteFilter[noteNumber] == true)
			{
				Debug.Log("NoteOn");
				OnNoteOn();
			}
		}
	}

	public void NoteOff(int instrument, int noteNumber)
	{
		//Debug.Log(string.Format("MidiEventTrigger - NoteOn {0:d}, {1:d}", instrument, noteNumber));
        _noteOn = false;

		if(instrumentFilter[instrument] == true && noteFilter[noteNumber] == true)
		{
			Debug.Log("NoteOff");
			OnNoteOff();
		}
    }

  	protected virtual void OnPlay()
	{
	}

	protected virtual void OnPause()
	{
	}

	protected virtual void OnResume()
	{
	}

	protected virtual void OnStop()
	{
	}

	protected virtual void OnNoteOn()
	{
	}

	protected virtual void OnNoteOff()
	{
  	}

}