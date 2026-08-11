using System;

namespace Tema12Ej2
{
	internal class AlarmSound
	{
		private ChronoTimer _chronoTimer;
		
		public AlarmSound(ChronoTimer chrono)
		{
			_chronoTimer = chrono;
		}
			
		public void Subscribe()
		{
			_chronoTimer.OnAlarmRaised += _chronoTimer_OnAlarmRaised;
		}
	
		public void Unsubscribe()
		{
			_chronoTimer.OnAlarmRaised -= _chronoTimer_OnAlarmRaised;
		}
	
		private void _chronoTimer_OnAlarmRaised(object? sender, EventArgs e)
		{
			Console.Beep();
		}

	}
}