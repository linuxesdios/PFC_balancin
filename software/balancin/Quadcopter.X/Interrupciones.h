/* 
 * File:   Interrupciones.h
 * Author: pablo
 *
 * Created on 14 de agosto de 2014, 12:17
 */

#ifndef INTERRUPCIONES_H
#define	INTERRUPCIONES_H

#include <xc.h>
#include "Defines.h"
void interrupcion _INT0Interrupt(void);
void interrupcion _INT2Interrupt(void);
extern int act_motor;
#endif	/* INTERRUPCIONES_H */

