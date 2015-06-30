using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class TerminalComponent : MonoBehaviour {
	
	public TerminalController terminalController;

	public Text terminalOutput;
	public InputField terminalInput;

	bool activateTextField = false;

	// Use this for initialization
	void Start () {
		terminalController = new TerminalController();
	}
	
	// Update is called once per frame
	void Update () {
		if (terminalController.displayDirty) {
			terminalOutput.text = terminalController.StringifyTerminal();
			terminalController.displayDirty = false;
		}

		if (activateTextField) {
			activateTextField = false;
		
			terminalInput.Select();
			terminalInput.ActivateInputField();
		}
	}
	
	public void OnEndEdit(string command) {
		terminalController.ExecuteCommand(command);
		terminalInput.text = "";

		activateTextField = true;	// will activate on next frame
	}

}
