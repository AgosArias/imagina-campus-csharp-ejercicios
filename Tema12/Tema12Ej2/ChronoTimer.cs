using System;
using System.Threading;

namespace Tema12Ej2
{
	class ChronoTimer
	{
		private int _seconds;

        public event EventHandler<int> OnTimerTick;
        public event EventHandler OnAlarmRaised;

        public ChronoTimer(int seconds)
        {
            _seconds = seconds;
        }
        public void Start()
        {
            while(_seconds > 0)
            {
                OnTimerTick?.Invoke(this,_seconds);
                _seconds--;
                Thread.Sleep(1000);
            }
            OnAlarmRaised?.Invoke(this,EventArgs.Empty);
        }
	}
}