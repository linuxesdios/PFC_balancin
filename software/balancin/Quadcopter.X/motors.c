
#include "motors.h"

void SetPwm1(int velocidad) {
    if (velocidad < 0)
        PWM1 = 0;
    else
        PWM1 = velocidad;
}

void SetPwm2(int velocidad) {
    if (velocidad < 0)
        PWM2 = 0;
    else
        PWM2 = velocidad;
}

void SetPwm3(int velocidad) {
    if (velocidad < 0)
        PWM3 = 0;
    else
        PWM3 = velocidad;
}

void SetPwm4(int velocidad) {
    if (velocidad < 0)
        PWM4 = 0;
    else
        PWM4 = velocidad;
}