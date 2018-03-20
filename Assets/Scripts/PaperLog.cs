using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperLog : MonoBehaviour {
	public int logIndex;

	void Use (GameObject owner) {
		owner.GetComponent<PlayerReferenceManager>().playerCenterTabButtonsControl.TabButtonClickSilent(4);
		MFDManager.a.SendPaperLogToDataTab(logIndex);
	}
}
