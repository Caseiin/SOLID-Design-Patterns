// Command pattern

using OOP_Tutorials.Design_Patterns.Behavioural.Command;

var light = new Light();
var remote = new RemoteControl(new TurnOn(light));
remote.PressButtton();

remote.SetCommand(new TurnOff(light));
remote.PressButtton();