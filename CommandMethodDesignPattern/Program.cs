using CommandMethodDesignPattern;

RemoteControl remoteControl = new RemoteControl();
Light light = new Light();
remoteControl.Execute(new LightOnCommand(light));
remoteControl.Execute(new LightOffCommand(light));
Stereo stereo = new Stereo();
remoteControl.Execute(new StereoOnCommand(stereo));

remoteControl.Execute(new StereoOffCommand(stereo));

