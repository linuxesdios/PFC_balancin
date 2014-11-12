/* 
 * File:   kalman.c
 * Author: pablo
 *
 * Created on 1 de agosto de 2014, 9:02
 */
#include "kalman.h"

void getAngle_init() {
    P[0][0] = 0; // Since we assume that the bias is 0 and we know the starting angle (use setAngle), the error covariance matrix is set like so - see: http://en.wikipedia.org/wiki/Kalman_filter#Example_application.2C_technical
    P[0][1] = 0;
    P[1][0] = 0;
    P[1][1] = 0;
    Q_angle = 0.03; //0.01 // Process noise variance for the accelerometer
    Q_bias = 0.001; //0.03  Process noise variance for the gyro bias
    R_measure = 0.002; //0.03 Measurement noise variance - this is actually the variance of the measurement noise
    angle = 1; // Reset the angle // The angle calculated by the Kalman filter - part of the 2x1 state vector
    bias = 0; // The gyro bias calculated by the Kalman filter - part of the 2x1 state vector
    rate = 0; // Unbiased rate calculated from the rate and the calculated bias - you have to call getAngle to update the rate
    K[2] = 0; // Kalman gain - This is a 2x1 vector
    y = 1; // Angle difference
    S = 100; // Estimate error
}

double kalman(double newAngle, double newRate, double dt) {
    rate = newRate - bias; //lectura mas sesgo
    angle += dt * rate; //angulo  con el modelo (newton)
    P[0][0] += dt * (dt * P[1][1] - P[0][1] - P[1][0] + Q_angle);
    P[0][1] -= dt * P[1][1];
    P[1][0] -= dt * P[1][1];
    P[1][1] += Q_bias * dt;
    S = P[0][0] + R_measure; //suma la varianza del ruido(aclculo intertermedio  para obtener L)
    K[0] = P[0][0] / S;
    K[1] = P[1][0] / S;
    y = newAngle - angle;
    angle += K[0] * y; //y angulo medido //angle=estimado
    bias += K[1] * y; //
    P[0][0] -= K[0] * P[0][0];
    P[0][1] -= K[0] * P[0][1];
    P[1][0] -= K[1] * P[0][0];
    P[1][1] -= K[1] * P[0][1];
    return angle;
}
