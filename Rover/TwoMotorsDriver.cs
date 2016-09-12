using Microsoft.IoT.Lightning.Providers;
using System;
using System.Threading.Tasks;

namespace Rover
{
    public class TwoMotorsDriver
    {
        private readonly Motor _leftMotor;
        private readonly Motor _rightMotor;

        public TwoMotorsDriver(Motor leftMotor, Motor rightMotor)
        {
            _leftMotor = leftMotor;
            _rightMotor = rightMotor;
        }

        public void Stop()
        {
            if (LightningProvider.IsLightningEnabled)
            {
                _leftMotor.SpeedPercentage(.0);
                _rightMotor.SpeedPercentage(.0);
            }
            _leftMotor.Stop();
            _rightMotor.Stop();
        }

        public void MoveForward()
        {
            if (LightningProvider.IsLightningEnabled)
            {
                _leftMotor.SpeedPercentage(.5);
                _rightMotor.SpeedPercentage(.5);
            }
            _leftMotor.MoveForward();
            _rightMotor.MoveForward();
        }

        public void MoveBackward()
        {
            if (LightningProvider.IsLightningEnabled)
            {
                _leftMotor.SpeedPercentage(.5);
                _rightMotor.SpeedPercentage(.5);
            }
            _leftMotor.MoveBackward();
            _rightMotor.MoveBackward();
        }

        public async Task TurnRightAsync()
        {
            if (LightningProvider.IsLightningEnabled)
            {
                _leftMotor.SpeedPercentage(.4);
                _rightMotor.SpeedPercentage(.4);
            }
            _leftMotor.MoveForward();
            _rightMotor.MoveBackward();

            await Task.Delay(TimeSpan.FromMilliseconds(250));

            _leftMotor.Stop();
            _rightMotor.Stop();
        }

        public async Task TurnLeftAsync()
        {
            if (LightningProvider.IsLightningEnabled)
            {
                _leftMotor.SpeedPercentage(.4);
                _rightMotor.SpeedPercentage(.4);
            }
            _leftMotor.MoveBackward();
            _rightMotor.MoveForward();

            await Task.Delay(TimeSpan.FromMilliseconds(250));

            _leftMotor.Stop();
            _rightMotor.Stop();
        }
    }
}