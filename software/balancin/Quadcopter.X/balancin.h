/* 
 * File:   main.h
 * Author: Pablo
 *
 * Created on 20 de octubre de 2013, 23:39
 */

#ifndef BALANCIN_H
#define	BALANCIN_H



#include <xc.h>
#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#include <math.h>
#include <libq.h>
#include <dsp.h>
#include "variables_globales.h"
#include "Defines.h"
#include "Init.h"
#include "motors.h"
#include "Timers.h"
#include "Bluetooth.h"
#include "eeprom.h"
#include "complementary.h"
#include "kalman.h"
#include "carga_datos.h"
#include "pid.h"
#include "Interrupciones.h"


char str_blue[40];
char str_aux[40];
extern int act_motor;
extern int setpoint;
extern int tipoFiltro;
extern float ErrorI;
void Bucle_Principal();
void get_calibrado_acelerometro(int milis, int n);



#endif	/* MAIN_H */