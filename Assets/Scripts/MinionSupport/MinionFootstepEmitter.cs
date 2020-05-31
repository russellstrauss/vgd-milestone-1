using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionFootstepEmitter : MonoBehaviour {

	private int count = 0;
    public void ExecuteFootstep() {

        EventManager.TriggerEvent<MinionFootstepEvent, Vector3>(transform.position);
		Debug.Log("Footstep " + count.ToString());
		count++;
    }
}
