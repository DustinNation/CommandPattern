using CommandPattern.Commands;
using CommandPattern.Objects;
using StrategyPattern.Commands;
using StrategyPattern.Interfaces;
using StrategyPattern.Objects;
using StrategyPattern.Remote;

var remote = new RemoteControl();

//RemoteControlWithUndoForLights();
//RemoteControlWithUndoCeilingFan();

var light = new Light("Living Room");
var tv = new TV("Living Room");
var stereo = new Stereo("Living Room");
var hotTub = new HotTub();

var lightOnCommand = new LightOnCommand(light);
var lightOffCommand = new LightOffCommand(light);

var stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);
var stereoOffCommand = new StereoOffCommand(stereo);

var tvOnCommand = new TvOnCommand(tv);
var tvOffCommand = new TvOffCommand(tv);

var hotTubOnCommand = new HotTubOnCommand(hotTub);
var hotTubOffCommand = new HotTubOffCommand(hotTub);

ICommand[] partyOn = { lightOnCommand, stereoOnWithCdCommand, tvOnCommand, hotTubOnCommand };
ICommand[] partyOff = { lightOffCommand, stereoOffCommand, tvOffCommand, hotTubOffCommand };

var partyOnMacro = new MacroCommand(partyOn);
var partyOffMacro = new MacroCommand(partyOff);

remote.SetCommand(0, partyOnMacro, partyOffMacro);

remote.GenerateCommandString();

Console.WriteLine();
Console.WriteLine("-------------------- Pushing Macro On --------------------");
remote.OnButtonWasPushed(0);

Console.WriteLine();
Console.WriteLine("-------------------- Pushing Macro Off --------------------");
remote.OffButtonWasPushed(0);

void RemoteControlWithUndoForLights()
{
    var livingRoomLight = new Light("Living Room");
    var kitchenLight = new Light("Kitchen");

    var ceilingFan = new CeilingFan("Living Room");

    var garageDoor = new GarageDoor("Garage");

    var stereo = new Stereo("Living Room");

    var livingRoomLightOn = new LightOnCommand(livingRoomLight);
    var livingRoomLightOff = new LightOffCommand(livingRoomLight);

    var kitchenLightOn = new LightOnCommand(kitchenLight);
    var kitchenLightOff = new LightOffCommand(kitchenLight);

    var ceilingFanOn = new CeilingFanHighCommand(ceilingFan);
    var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

    var garageDoorUpCommand = new GarageDoorUpCommand(garageDoor);
    var garageDoorDownCommand = new GarageDoorDownCommand(garageDoor);

    var stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);
    var stereoOffCommand = new StereoOffCommand(stereo);

    remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
    remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
    remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
    remote.SetCommand(3, stereoOnWithCdCommand, stereoOffCommand);


    remote.OnButtonWasPushed(0);
    remote.OffButtonWasPushed(0);

    remote.GenerateCommandString();

    remote.UndoButtonWasPushed();

    remote.OffButtonWasPushed(1);
    remote.OnButtonWasPushed(1);

    remote.UndoButtonWasPushed();

    remote.OnButtonWasPushed(2);
    remote.OffButtonWasPushed(2);

    remote.OnButtonWasPushed(3);
    remote.OffButtonWasPushed(3);
}

void RemoteControlWithUndoCeilingFan()
{
    var ceilingFan = new CeilingFan("Living Room");

    var ceilingFanMediumCommand = new CeilingFanMediumCommand(ceilingFan);
    var ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
    var ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);
    var ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

    remote.SetCommand(0, ceilingFanMediumCommand, ceilingFanOffCommand);
    remote.SetCommand(1, ceilingFanHighCommand, ceilingFanOffCommand);

    remote.OnButtonWasPushed(0);
    remote.OffButtonWasPushed(0);

    remote.GenerateCommandString();
    
    remote.UndoButtonWasPushed();
    
    remote.OnButtonWasPushed(1);
    remote.GenerateCommandString();

    remote.UndoButtonWasPushed();
}
