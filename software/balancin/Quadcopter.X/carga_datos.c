/* 
 * File:   carga_datos.c
 * Author: pablo
 *
 * Created on 1 de agosto de 2014, 1:09
 */
#include "carga_datos.h"


void cargar_datos_ajuste() {
    if (Eeprom_ReadWord(0) == 6969) {

        enviar_mensaje("datos encontrados en la eeprom");

        KP = Eeprom_ReadWord(2) / 10;
        KI = Eeprom_ReadWord(4) / 10;
        KD = Eeprom_ReadWord(6) / 10;
        BIAS1 = Eeprom_ReadWord(8);
        BIAS2 = Eeprom_ReadWord(10);
        k = Eeprom_ReadWord(12);
        Q_angle = (float)Eeprom_ReadWord(14)/1000;
        Q_bias = (float)Eeprom_ReadWord(16)/1000;
        R_measure =(float) Eeprom_ReadWord(18)/1000;
        Tsample =  Eeprom_ReadWord(20);
        filtro = Eeprom_ReadWord(22);
        tipoFiltro = Eeprom_ReadWord(24);

    } else {
        enviar_mensaje("datos no  encontrados en la eeprom, cargando datos seguros");
        KP = 10;
        KD = 40;
        KI = 0;
        BIAS1 = 1000;
        BIAS2 = 1000;
        k = 35;
        Q_angle = 1;
        Q_bias = 1;
        R_measure = 1;
        Tsample = 5;
        filtro = 6;
    }
    //------------------CARGADO LOS DATOS DESDE  LA EEPROM--------------------------//

    enviar_valor_NOCR("KP=", KP * 10);
    enviar_valor_NOCR(" , KD=", KD * 10);
    enviar_valor_NOCR(" , KI=", KI * 10);
    enviar_valor_NOCR(" , BIAS1=", BIAS1);
    enviar_valor(" , BIAS2=", BIAS2);
    enviar_valor("k=", (float) k);
    enviar_valor_NOCR("Q_angle=", (float)Q_angle*1000);
    enviar_valor_NOCR(" , Q_bias=", (float)Q_bias*1000);
    enviar_valor(" , R_measure=", (float)R_measure*1000);
    enviar_valor_NOCR("Tsample=", Tsample);
    enviar_valor(" , filtro=", filtro);
    if (tipoFiltro==1)enviar_mensaje("filtro Kalman");else enviar_mensaje("filtro complementario");





}
