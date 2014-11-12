/* 
 * File:   complementary.c
 * Author: pablo
 *
 * Created on 1 de agosto de 2014, 0:59
 */
#include "complementary.h"

float Complementary2(float newAngle, float newRate, int looptime) {
    float dtc2 = 0, x1 = 0, y1 = 0, x2 = 0;
    dtc2 = (float) (looptime) / 1000.0;
    x1 = (newAngle - angle2C) * k*k;
    y1 = dtc2 * x1 + y1;
    x2 = y1 + (newAngle - angle2C)*2 * k + newRate;
    angle2C = dtc2 * x2 + angle2C;
    return angle2C;
}