using System;

namespace Tema12Ej2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ChronoTimer chrono = new ChronoTimer(10);
			DisplayScreen display = new DisplayScreen(chrono);
			AlarmSound alarm = new AlarmSound(chrono);
			chrono.OnAlarmRaised += (sender, eventArgs) => { display.Unsubscribe(); alarm.Unsubscribe(); };
			display.Subscribe();
			alarm.Subscribe();
			chrono.Start();
		}
	}
}