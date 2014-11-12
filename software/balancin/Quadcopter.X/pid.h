/* 
 * File:   pid.h
 * Author: pablo
 *
 * Created on 3 de agosto de 2014, 21:51
 */

#ifndef PID_H
#define	PID_H

extern int Tsample;
extern float error_anterior;
extern float ErrorI;

int pid(int _referencia, int _PosicionActual, int Tmuestreo, float _kp, float _ki, float _kd, int _Maximo, int _Minimo, int _MaximoI, int _MinimoI) ;


#endif	/* PID_H */

