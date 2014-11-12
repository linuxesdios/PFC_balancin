/* 
 * File:   pid.c
 * Author: pablo
 *
 * Created on 3 de agosto de 2014, 21:52
 */

#include "Bluetooth.h"


#include "pid.h"

int pid(int _referencia, int _PosicionActual, int Tmuestreo, float _kp, float _ki, float _kd, int _Maximo, int _Minimo, int _MaximoI, int _MinimoI) {
    float salida, ITerm;
    int ErrorP = _referencia - _PosicionActual;
    float ErrorDT = ErrorP - error_anterior;
//
   // if (error_anterior>0 && ErrorDT<0 ||error_anterior<0 && ErrorDT>0)ErrorI=0;


    //-----calculate P component
    float PTerm = ErrorP * _kp;

    //-----calculate I component
    ErrorI = ErrorI + ErrorP * _ki*Tmuestreo;

    //-----calculate D component
    float DTerm = ErrorDT * _kd * 1000 / Tmuestreo;

    //-----calculate anti-windup
    if (ErrorI >= _MaximoI) ErrorI = _MaximoI;
    else if (ErrorI <= _MinimoI) ErrorI = _MinimoI;
    ITerm = ErrorI;

    //-----calculate PID
    salida = PTerm + DTerm + (ITerm/10);

    if (salida >= _Maximo) salida = _Maximo;
    if (salida <= _Minimo) salida = _Minimo;

    error_anterior = ErrorP;

    return (int)salida;
}




