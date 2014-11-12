#include <p30F4013.h>

#include "Timers.h"
#include "Init.h"

void Delay1msT1(unsigned char _Interrupcion)
{
    T1CON = 0b0000000000010000; // Preescala 1:8
    PR1 = 0x0E60;       // 0x0E30 segun excel
    TMR1 = 0;
    IFS0bits.T1IF = 0;
    T1CONbits.TON = 1;
    _T1IE = _Interrupcion;
    if(!_Interrupcion)
    {
        while(IFS0bits.T1IF == 0);
        T1CONbits.TON = 0;
    }
}

void interrupcion _T1Interrupt(void)
{
    Delay1msT1(1);
}


void DelayXmsT1(int _msg)
{
    do
    {
        Delay1msT1(0);
        _msg--;
    }while(_msg >=0);
}

/**********************************************************
 *                                                        *
 *                                                        *
 * NO UTILIZAR TEMPORIZADOR 2--> SE USA PARA EL PWM       *
 *                                                        *
 *                                                        *
***********************************************************/

void Delay_Nop(unsigned int _contador)
{
    while(_contador>0)
    {
        Nop();
        _contador--;
    }
}

/**********************************************************
 *                                                        *
 *                                                        *
 * UTILIZADO TEMPORIZADOR 3 PARA EL PID --> 2/3 msg       *
 *                                                        *
 *                                                        *
***********************************************************/

void SetupT3ForXmsPID(int _tiempo)
{
    T3CON = 0b0000000000100000; // Preescala 1:x
    PR3 =_tiempo*464 ; // cada milisegundo es 0x1d0 asi que lo multiplico por el numero de ms
    TMR3 = 0;
    IFS0bits.T3IF = 0;
    T3CONbits.TON = 0;
     _T3IE = 1;
     _T3IP=0b001;

}

void StartInterrup3()
{
    T3CONbits.TON = 1;
}
void StopInterrup3()
{
    T3CONbits.TON = 0;
}


void interrupcion _T3Interrupt(void)
{

   Bucle_Principal();

IFS0bits.T3IF = 0;
}


//TEMPO 5
void SetupT4For20msPID()
{
    T4CON = 0b0000000000110000; // Preescala 1:x
//    PR4 =12*464 ; //20 ms
    PR4 =0xffff ; // parece mas bonito
    TMR4 = 0;
    _T4IP=0b011;
    T4CONbits.T32=0;
    IFS1bits.T4IF = 0;
    T4CONbits.TON = 0;
     _T4IE = 1;
     
}
void StartInterrup4()
{
    T4CONbits.TON = 1;
     
}
void StopInterrup4()
{
    T4CONbits.TON = 0;
}

void interrupcion _T4Interrupt(void)
{

LED_VERDE_ACT= !LED_VERDE_ACT;
  IFS1bits.T4IF = 0;
}
