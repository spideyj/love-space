using System;
using UnityEngine;
using System.Collections;
using Fungus;


public class TerminalCommandExit : ITerminalCommand {
	public TerminalCommandExit ()
	{
	}
	public void Execute (string[] args, TerminalController terminal)
	{
		Flowchart.BroadcastFungusMessage ("Exit");
		

	}

	public string GetHelpString () {
		return "Exits the terminal.";
	}
}
