The Rover is an obstacle avoidance robot. It just runs full steam ahead until it detects an obstacle in its path at which point it turns and then continues to move forward. The Rover is built on a Raspberry Pi 2 running Microsoft Windows IoT Core. A full description of the project along with a parts list and assembly instructions can be found at http://www.hackster.io/peejster/rover

This fork has support for using the PWM controller in the Raspberry Pi 2/3 to control the speed of the motors.

##Here is the documentation used to enable the PWM comtroler in the Raspberry Pi 2/3

* [Lightning Driver Setup Guide](https://developer.microsoft.com/en-us/windows/iot/docs/LightningSetup.htm)
* [How to Fade an LED with PWM in Windows IoT](http://www.codeproject.com/Articles/1095762/How-to-Fade-an-LED-with-PWM-in-Windows-IoT)
* [A servo library in C# for Raspberry Pi 3 - Part #1, implementing PWM](https://jeremylindsayni.wordpress.com/2016/05/08/a-servo-library-in-c-for-raspberry-pi-3-part-1-implementing-pwm/)
* Wikipedia entry for [PWM](https://en.wikipedia.org/wiki/Pulse-width_modulation)

## Prerequisites

* Raspberry PI 2/3 with the latest [Windows 10 IoT Core Insider Preview](https://developer.microsoft.com/en-US/windows/iot/GetStarted)
* Raspberry PI 2/3 setup with the [Direct Memory Mapper Dirver](https://developer.microsoft.com/en-us/windows/iot/docs/LightningSetup.htm)
* Visual Studio 2015 Comunitiy Edition or better
* Windows 10 SDK 10.0.10586.0
* Microsoft.Iot.Lighting (From Nuget)


## Notes

The project uses two GPIOs (13,18) for PWM output. One for each motor. Add a cable that connects each GPIO to their respective PWM input to control the motor speed.

Here is a [table](http://raspberrypi.stackexchange.com/a/40816) with the GPIO pins that can be used for PWM:

| GPIO | PWM channel | Harware supported                      |
|:----:|:-----------:|---------------------------------------:|
|   12 |      0      | A+/B+/Pi2/Pi3/Zero and compute module only |
|   13 |      1      | A+/B+/Pi2/Pi3/Zero and compute module only |
|   18 |      0      | All models                             |
|   19 |      1      | A+/B+/Pi2/Pi3/Zero and compute module only |
|      |             |                                        |
|   40 |      0      | Compute module only                    |
|   41 |      1      | Compute module only                    |
|   45 |      1      | Compute module only                    |
|   52 |      0      | Compute module only                    |
|   53 |      1      | Compute module only                    |

