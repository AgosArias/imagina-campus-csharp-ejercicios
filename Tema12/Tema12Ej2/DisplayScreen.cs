using System;

namespace Tema12Ej2
{
	class DisplayScreen
	{
		private ChronoTimer _chrono;

        public DisplayScreen(ChronoTimer chrono)
        {
            _chrono = chrono;
        }
        public void Subscribe()
        {
            _chrono.OnTimerTick += _chrono_OnTimerTick;
            _chrono.OnAlarmRaised += _chrono_OnAlarmRaised;
        }

        private void _chrono_OnAlarmRaised(object? sender, EventArgs e)
        {
            Console.WriteLine("TEMPORIZADOR FINALIZADO");
        }
        private void _chrono_OnTimerTick(object? sender, int e)
        {
            Console.WriteLine(e);
        }

        public void Unsubscribe()
        {            
            _chrono.OnTimerTick -= _chrono_OnTimerTick;
            _chrono.OnAlarmRaised -= _chrono_OnAlarmRaised;}
	}
}