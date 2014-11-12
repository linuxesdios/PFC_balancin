/* 
 * File:   carga_datos.h
 * Author: pablo
 *
 * Created on 1 de agosto de 2014, 1:09
 */

#ifndef CARGA_DATOS_H
#define	CARGA_DATOS_H
#include "eeprom.h"
#include "Bluetooth.h"

extern int KP ;
extern int KD;
extern int KI;
extern int BIAS1;
extern int BIAS2;
extern float k;
extern float filtro;
extern int Tsample;
extern double Q_angle;
extern double Q_bias;
extern double R_measure;
extern int tipoFiltro;
void cargar_datos_ajuste(void);
#endif	/* CARGA_DATOS_H */

