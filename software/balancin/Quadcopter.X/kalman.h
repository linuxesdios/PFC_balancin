/* 
 * File:   kalman.h
 * Author: pablo
 *
 * Created on 1 de agosto de 2014, 9:03
 */

#ifndef KALMAN_H
#define	KALMAN_H



extern double Q_angle ;//0.01 // Process noise variance for the accelerometer
extern double Q_bias ; //0.03  Process noise variance for the gyro bias
extern double R_measure; //0.03 Measurement noise variance - this is actually the variance of the measurement noise

extern double angle; // Reset the angle // The angle calculated by the Kalman filter - part of the 2x1 state vector
extern double bias; // The gyro bias calculated by the Kalman filter - part of the 2x1 state vector
extern double rate; // Unbiased rate calculated from the rate and the calculated bias - you have to call getAngle to update the rate

extern double P[2][2]; // Error covariance matrix - This is a 2x2 matrix
extern double K[2]; // Kalman gain - This is a 2x1 vector
extern double y; // Angle difference
extern double S; // Estimate error

double kalman(double newAngle, double newRate, double dt) ;
void getAngle_init();

#endif	/* KALMAN_H */

