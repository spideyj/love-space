using System;
using UnityEngine;
using System.Collections;
using Fungus;


public class TerminalCommandMerge : ITerminalCommand {

	public TerminalCommandMerge ()
	{
	}
	public void Execute (string[] args, TerminalController terminal)
	{
		Flowchart.BroadcastFungusMessage ("Merge");
		terminal.PrintString ("Merging personality.alice, incorporating new architecture\n...\n...\nMerge complete.");
	}
	
	public string GetHelpString () {
		return "Function unknown.";
	}
}
