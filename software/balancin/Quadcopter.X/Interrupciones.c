#include <xc.h>
#include "Interrupciones.h"
#define interrupcion	__attribute__((interrupt,no_auto_psv))

void interrupcion _INT0Interrupt(void)
{
       IFS0bits.INT0IF = 0;
       act_motor=!act_motor;

}

void interrupcion _INT2Interrupt(void)
{
    reset();
    IFS1bits.INT2IF = 0;

}

