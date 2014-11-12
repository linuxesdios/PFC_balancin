/* 
 * File:   variables_globales.h
 * Author: pablo
 *
 * Created on 24 de enero de 2014, 1:37
 */

#ifndef VARIABLES_GLOBALES_H
#define	VARIABLES_GLOBALES_H

//*************************************************************
//*********************VARIABLES GLOBALES**********************
//*************************************************************
int Tsample=4;


//***********variables del pid********************//

int KP = 1000;
int KD = 10;
int KI = 1;
int BIAS1 = 1000;
int BIAS2 = 1000;
int act_motor=0;
int Tmuestreo = 8;
float  error_anterior=0;
float  ErrorI=0;
int setpoint =0;
float filtro = 20;

int tipoFiltro=0;

//************************* VARIABLES DE KALMAN ****************//

double Q_angle = 0.03;//0.01 // Process noise variance for the accelerometer
double Q_bias = 0.03; //0.03  Process noise variance for the gyro bias
double R_measure= 0.002; //0.03 Measurement noise variance - this is actually the variance of the measurement noise

double angle = 1; // Reset the angle // The angle calculated by the Kalman filter - part of the 2x1 state vector
double bias = 0; // The gyro bias calculated by the Kalman filter - part of the 2x1 state vector
double rate=0; // Unbiased rate calculated from the rate and the calculated bias - you have to call getAngle to update the rate

double P[2][2]; // Error covariance matrix - This is a 2x2 matrix
double K[2]; // Kalman gain - This is a 2x1 vector
double y=1; // Angle difference
double S=100; // Estimate error
//************************* VARIABLES DE COMPLEMENTARY ****************//
float k=1;
float angle2C=0;
int i=0;




//************************* VARIBLES DE CALIBRADO ****************//
double calibra_ax=0;
double calibra_ay=0;
double calibra_az=0;
double calibra_gx=0;
double calibra_gy=0;
double calibra_gz=0;

//-------------------------------------------------------------
//necesarias por que las inperrupciones no permiten parametros
//-------------------------------------------------------------

#endif	/* VARIABLES_GLOBALES_H */

