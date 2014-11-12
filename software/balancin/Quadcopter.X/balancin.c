/*
 * File:   main.c
 * Author: Pablo
 *
 * Created on 29 de junio de 2013, 19:05
 */
#include "balancin.h"

#define MY_FRC                  0xF9E3
// FUSES
// -----------------------------------------------------------

_FOSC(MY_FRC & CSW_FSCM_ON) //   0xF9E3 & 0x3FFF --> Arranca sin PLL (8MHz) y se habilita el clockSwitch
_FGS(GWRP_OFF & CODE_PROT_OFF)
_FICD(ICS_PGD1)
_FWDT(WDT_OFF)
_FBORPOR(PWRT_OFF & BORV27 & PBOR_OFF & MCLR_DIS)
// FIN FUSES

int main(void) {

    //***************************************************************************************//
    //*****************ARRANCAMOS LA CONFIGURACION DEL PIC **********************************//
    //***************************************************************************************//
    Init_Hw();
    Delay1msT1(0); //Configuramos el puertos y quitamos analogicos
    Init_Pll();
    Delay1msT1(0); //configuramos el pll que abiasmos arracamos sin él
    Init_PWM();
    Delay1msT1(0); //configuramos el PWM
    init_interr_extern();
    Delay1msT1(0); //configuramos las interrupciones externas
    Init_Bluetooh();
    Delay1msT1(0); //Configuramos el serial-Bluetooth
    cargar_datos_ajuste();
    Init_I2C();
    Delay1msT1(0); //incializamos el I2c
    set_inicial();
    Delay1msT1(0); //Configuramos la incialicacion de sensor
    getAngle_init();
    Delay1msT1(0); //Incializamos el filtro kalman
    set_inicial();
    Delay1msT1(0); //Incializamos el acelerometro
    LED_ALL_ON();
    for (i = 0; i < 2500; i++) Delay_Nop(2000);
    LED_ALL_OFF();



    
   
    //***************************************************************************************//
    //***************************************************************************************//

    //*****************CALIBRAMOS EL ACELEROMETRO Y GIROSCOPO *******************************//
   // get_calibrado_acelerometro(5, 50); //cojemos los valres por defecto del  giroscopo y aceletometro
    LED_ALL_OFF();
    //***************************************************************************************//

    //*****************INICIALIZAMOS EL PID  Y LAS VARIABLES ********************************//

    //     pid_dsp_configuracion();

    //***************************************************************************************//
LED_ALL_OFF();

    //*****************ARRANCAMOS INTERRUPCION  DEL BUCLE PRINCIPAL *************************//

        SetupT3ForXmsPID(Tsample); //configuramos  la interrupcion principal
        SetupT4For20msPID(); //configuramos  la interrupcion principal
        StartInterrup4(); //incializamos la interrupcion

      StartInterrup3(); //incializamos la interrupcion


    enviar_mensaje("------------------------------------------------------");
    //***************************************************************************************//
    while (1) {

    }

}

void Bucle_Principal() {
 int salida=0;
   int angulo = 0;
   int who_a_I_tmp = 0;
    //------------------------------------------------------------------------------------------//
    double accXangle = (atan2(get_ax(), -get_ay()) * RAD_TO_DEG );
    double gyroXrate = (double) (get_gz() ) / 131.0;

    if (tipoFiltro==1){
angulo = (signed int) Complementary2(accXangle, gyroXrate,Tsample)-90;
    
    }
    else {
angulo = (signed int) kalman(accXangle, gyroXrate,Tsample)-90;

    }




    

    if (act_motor==1){
        salida = pid(setpoint, angulo,5, KP, KI, KD, 5000, -5000, 10000, -10000);
        SetPwm1(BIAS1 - salida);
        SetPwm2(BIAS2 + salida);
        who_a_I_tmp = get_who_I_AM();        
        if(who_a_I_tmp != 104)
        {
            Init_I2C();
            reset();
        }
        enviar_valor_NOCR("ax= ",get_ax());
        enviar_valor_NOCR(" ay = ",get_ay());
        enviar_valor_NOCR(" gz= ",get_gz());
        enviar_valor(" who = ",get_who_I_AM());
    }
    else {
        SetPwm1(0);
        SetPwm2(0);
        ErrorI=0;
    }
    plot4(accXangle-90,angulo,salida/10,setpoint);


    LED_ROJO=!LED_ROJO;

}


