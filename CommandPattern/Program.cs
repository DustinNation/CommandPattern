using StrategyPattern.Commands;
using StrategyPattern.Objects;
using StrategyPattern.Objects.GarageDoor;
using StrategyPattern.Objects.Lights;
using StrategyPattern.Objects.Stereo;
using StrategyPattern.Remote;

var remote = new RemoteControl();

var livingRoomLight = new Light("Living Room");
var kitchenLight = new Light("Kitchen");

var ceilingFan = new CeilingFan("Living Room");

var garageDoor = new GarageDoor("Garage");

var stereo = new Stereo("Living Room");

var livingRoomLightOn = new LightOnCommand(livingRoomLight);
var livingRoomLightOff = new LightOffCommand(livingRoomLight);

var kitchenLightOn = new LightOnCommand(kitchenLight);
var kitchenLightOff = new LightOffCommand(kitchenLight);

var ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

var garageDoorUpCommand = new GarageDoorUpCommand(garageDoor);
var garageDoorDownCommand = new GarageDoorDownCommand(garageDoor);

var stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);
var stereoOffCommand = new StereoOffCommand(stereo);

remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
remote.SetCommand(1,kitchenLightOn,kitchenLightOff);
remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
remote.SetCommand(3, stereoOnWithCdCommand, stereoOffCommand);

Console.WriteLine(remote.GenerateCommandString());

remote.OnButtonWasPushed(0);
remote.OffButtonWasPushed(0);

remote.OnButtonWasPushed(1);
remote.OffButtonWasPushed(1);

remote.OnButtonWasPushed(2);
remote.OffButtonWasPushed(2);

remote.OnButtonWasPushed(3);
remote.OffButtonWasPushed(3);